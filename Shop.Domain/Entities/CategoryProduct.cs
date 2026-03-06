using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shop.Domain.Entities;

[PrimaryKey(nameof(CategoryId), nameof(ProductId))]
public class CategoryProduct
{
    [ForeignKey(nameof(Category))]
    public int? CategoryId { get; set; }
    public Categories? Category { get; set; }
    
    [ForeignKey(nameof(Product))]
    public int? ProductId { get; set; }
    public Product? Product { get; set; }
    
    [Range(0, int.MaxValue)]
    public int Store { get; set; }
}