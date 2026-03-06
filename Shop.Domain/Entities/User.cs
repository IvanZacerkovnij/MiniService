using System.ComponentModel.DataAnnotations;
using Shop.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Entities;


public class User
{
    [Key]
    public int Id { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    
    [Required]
    [StringLength(255)]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    [StringLength(255)]
    public string Surname { get; set; } = string.Empty;
    
    public string? HashPassword { get; set; }
    
    [Range(0, 3)]
    public UserRole Role { get; set; } = UserRole.USER;
    
    public DateTime CreatedAt { get; set; }
}