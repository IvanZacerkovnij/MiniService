using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.App.Data;

public class CategoryConfigurator : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .HasKey(c => c.Id);
        builder
            .HasIndex(c => c.Name)
            .IsUnique();
        builder
            .Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(255);
        builder
            .Property(c => c.CreatedAt)
            .HasDefaultValue(DateTime.Now);
    }
}