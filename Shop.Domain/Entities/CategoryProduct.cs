namespace Shop.Domain.Entities;

public class CategoryProduct
{
    public int? CategoryId { get; set; }
    public Categories? Category { get; set; }
    
    public int? ProductId { get; set; }
    public Product? Product { get; set; }
    
    public int Store { get; set; }
}