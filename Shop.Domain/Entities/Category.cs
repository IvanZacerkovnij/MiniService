namespace Shop.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    
    public ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();
}