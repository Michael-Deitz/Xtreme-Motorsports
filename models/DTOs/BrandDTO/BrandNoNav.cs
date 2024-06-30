using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class BrandNoNavDTO
{
    public int Id { get; set; }
    [Required]
    public string Make { get; set; }
}