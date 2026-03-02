using Shop.Domain.Enum;

namespace Shop.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string? HashPassword { get; set; }
    public UserRole Role { get; set; } = UserRole.USER;
    public DateTime CreatedAt { get; set; }
}