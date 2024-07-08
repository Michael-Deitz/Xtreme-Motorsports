using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models.DTOs;

public class VehiclesToCreateDTO
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    [Required]
    public int TypeOfVehicleId { get; set; }
    [Required]
    public int SizeId { get; set; }
    public int UserProfileId { get; set; }
    public string ImageUrl { get; set; }
}