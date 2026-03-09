namespace Shop.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CategoryId { get; set; }
    
    public ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();
    
}