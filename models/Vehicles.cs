using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class Vehicles
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    [Required]
    public int TypeOfVehicleId { get; set; }
    public TypeOfVehicle TypeOfVehicle { get; set; }
    [Required]
    public int SizeId { get; set; }
    public Size Size { get; set; }
    public string ImageUrl { get; set; }
    public int UserProfileId { get; set; }
    public UserProfile UserProfile { get; set; }
}