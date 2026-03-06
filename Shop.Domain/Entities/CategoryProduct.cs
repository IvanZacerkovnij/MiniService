using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Entities;

public class CategoryProduct
{
    [Key]
    public int? CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Categories? Category { get; set; }
    
    [Key]
    public int? ProductId { get; set; }
    [ForeignKey(nameof(ProductId))]
    public Product? Product { get; set; }
    
    
    public int Store { get; set; }
}