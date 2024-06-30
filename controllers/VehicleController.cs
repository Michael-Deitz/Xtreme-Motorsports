using Microsoft.AspNetCore.Mvc;
using Xtreme.Models;
using Xtreme.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Xtreme.Models.DTOs;

namespace Xtreme.Controllers;


[ApiController]
[Route("api/[controller]")]
public class VehicleController : ControllerBase
{
    private XtremeDbContext _dbContext;

    public VehicleController(XtremeDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    
    public IActionResult GetAllVehicles()
    {
        List<VehiclesNoNavDTO> vehicles = _dbContext.Vehicles
            .Include(v => v.Brand)
            .Include(v => v.TypeOfVehicle)
            .Include(v => v.Size)
            .Select(v => new VehiclesNoNavDTO
            {
                Id = v.Id,
                BrandId = v.Id,
                Brand = new Brand
                {
                    Id = v.Brand.Id,
                    Make = v.Brand.Make
                },
                TypeOfVehicleId = v.Id,
                Type = new TypeOfVehicle 
                {
                    Id = v.TypeOfVehicle.Id,
                    Type = v.TypeOfVehicle.Type
                },
                SizeId = v.Id,
                Size = new Size
                {
                    Id = v.Size.Id,
                    CubicCentimeters = v.Size.CubicCentimeters
                },
                ImageUrl = v.ImageUrl
            })
            .ToList();

        return Ok(vehicles);
    }

}