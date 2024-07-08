using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class SizeCreateDTO
{
    [Required]
    public int CubicCentimeters { get; set; }
    public int UserProfileId { get; set; }
}