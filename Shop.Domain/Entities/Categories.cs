using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Shop.Domain.Entities;

[Index(nameof(Name), IsUnique = true)]
public class Categories
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(1000)]
    public string Name { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; set; }
    public ICollection<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();
}