using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models.DTOs;

public class WorkOrderCreate
{
    public int Id { get; set; }
    [Required]
    public string Description { get; set; }
    public int VehiclesId { get; set; }
}