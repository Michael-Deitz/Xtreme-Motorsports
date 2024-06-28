using System.ComponentModel.DataAnnotations;

namespace Xtreme.Models;

public class TypeOfVehicle
{
    public int Id { get; set; }
    [Required]
    public string Type { get; set; }
}