using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class TypeCreateDTO
{
    [Required]
    public string Type { get; set; }
    public int UserProfileId { get; set; }
}