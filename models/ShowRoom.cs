using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class ShowRoom
{
    public int Id { get; set; }
    [Required]
    public int VehicleId { get; set; }
}