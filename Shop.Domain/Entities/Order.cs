using Shop.Domain.Enum;

namespace Shop.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }

    public User User { get; set; } = null!;
}