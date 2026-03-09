using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.App.Data;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder
            .HasKey(c => c.Id);
        builder
            .HasOne(o => o.User)
            .WithMany(u => u.Orders)
            .HasForeignKey(o => o.UserId);
        builder
            .Property(o => o.OrderDate)
            .HasDefaultValue(DateTime.Now);
        builder
            .Property(o => o.TotalAmount)
            .HasPrecision(18, 2);
        builder
            .ToTable(t =>
                t.HasCheckConstraint("CK_Status" , "[Status] BETWEEN 0 AND 2"));
    }
}