using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;

namespace Shop.App.Data;

public class ShopDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    
    public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ConfigurationUser());
        modelBuilder.ApplyConfiguration(new CategoryProductConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfigurator());
        modelBuilder.ApplyConfiguration(new ProductConfigurator());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
    }
}