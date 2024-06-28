using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class Brand
{
    public int Id { get; set; }
    [Required]
    public string Make { get; set; }
}