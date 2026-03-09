using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.App.Data;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder
            .HasKey(oi => oi.Id);
        builder
            .HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId)
            .OnDelete(DeleteBehavior.Restrict);
        builder
            .HasOne(oi => oi.Product)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.ProductId);
        builder
            .ToTable(t =>
                t.HasCheckConstraint("CK_Quantity", "[Quantity] > 0"));
        builder
            .Property(oi => oi.Price)
            .HasPrecision(18, 2);
    }
}