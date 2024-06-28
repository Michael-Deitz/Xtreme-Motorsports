using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class Vehicles
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    [Required]
    public int TypeId { get; set; }
    [Required]
    public int SizeId { get; set; }
    public string ImageUrl { get; set; }
}