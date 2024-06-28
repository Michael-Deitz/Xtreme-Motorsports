using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class Size
{
    public int Id { get; set; }
    [Required]
    public int CubicCentimeters { get; set; }
}