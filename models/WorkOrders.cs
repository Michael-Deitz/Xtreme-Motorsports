using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class WorkOrder
{
    public int Id { get; set; }
    [Required]
    public string Description { get; set; }
    public int VehicleId { get; set; }
}