using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shop.Domain.Entities;

[PrimaryKey(nameof(CategoryId), nameof(ProductId))]
public class CategoryProduct
{
    public int? CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Categories? Category { get; set; }
    public int? ProductId { get; set; }
    [ForeignKey(nameof(ProductId))]
    public Product? Product { get; set; }
    
    [Range(0, int.MaxValue)]
    public int Store { get; set; }
}