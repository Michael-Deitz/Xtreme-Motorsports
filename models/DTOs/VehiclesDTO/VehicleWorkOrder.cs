using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models.DTOs;

public class VehicleWorkOrdersDTO
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    [Required]
    public int TypeOfVehicleId { get; set; }
    public TypeOfVehicle Type { get; set; }
    [Required]
    public int SizeId { get; set; }
    public Size Size { get; set; }
    public string ImageUrl { get; set; }
}