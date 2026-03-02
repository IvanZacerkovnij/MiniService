using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.App.Data;

public class ConfigurationUser : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(u => u.Id);
        builder
            .HasIndex(u => u.Email)
            .IsUnique();
        builder
            .Property(u => u.Email)
            .IsRequired();
        builder
            .ToTable(t =>
                t.HasCheckConstraint("CK_User", "[Role] BETWEEN 0 AND 3"));
        builder
            .ToTable(t =>
                t.HasCheckConstraint("CK_UserSurname",
                    "LEN(LTRIM(Surname)) > 0"));
        builder
            .Property(u => u.CreatedAt)
            .HasDefaultValueSql("SYSDATETIME()");
    }
}