using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;

namespace Shop.App.Data;

public class ShopDbContext : DbContext
{
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<CategoryProduct> CategoryProducts { get; set; }
    
    public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new ConfigurationUser());
        // modelBuilder.ApplyConfiguration(new ConfigurationCategoryProduct());
    }
}