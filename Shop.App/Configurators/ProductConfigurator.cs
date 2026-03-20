using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.App.Data;

public class ProductConfigurator : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .HasKey(p => p.Id);
        builder
            .HasIndex(p => p.Name)
            .IsUnique();
        builder
            .Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(255);
        builder
            .Property(p => p.Price)
            .HasPrecision(18, 2);
    }
}