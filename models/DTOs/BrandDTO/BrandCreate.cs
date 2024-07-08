using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class BrandCreateDTO
{
    [Required]
    public string Make { get; set; }
    public int UserProfileId { get; set; }
}