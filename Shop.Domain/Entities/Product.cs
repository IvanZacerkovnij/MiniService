using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Shop.Domain.Entities;

[Index(nameof(Name), IsUnique = true)]
public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(1000)]
    public string Name { get; set; } = string.Empty;
    
    [Range(typeof(decimal), "0.01", "1000000.00")]
    public decimal Price { get; set; }
    
    public DateTime CreatedAt { get; set; }

    public ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();

}