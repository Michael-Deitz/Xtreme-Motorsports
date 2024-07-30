using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models.DTOs;

public class TypeNoNavDTO
{
    public int Id { get; set; }
    [Required]
    public string Type { get; set; }
}