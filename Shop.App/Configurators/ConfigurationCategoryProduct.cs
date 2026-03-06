using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.App.Data;

public class ConfigurationCategoryProduct : IEntityTypeConfiguration<CategoryProduct>
{
    public void Configure(EntityTypeBuilder<CategoryProduct> builder)
    {
        builder
            .HasKey(u => new { u.CategoryId, u.ProductId });
        builder
            .HasOne(cp => cp.Product)
            .WithMany(p => p.CategoryProducts)
            .HasForeignKey(cp => cp.ProductId);
        builder
            .HasOne(cp => cp.Category)
            .WithMany(c => c.CategoryProducts)
            .HasForeignKey(cp => cp.CategoryId);

    }
}