using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class WorkOrder
{
    public int Id { get; set; }
    [Required]
    public string Description { get; set; }
    public int VehiclesId { get; set; }
    public Vehicles Vehicles { get; set; }
}