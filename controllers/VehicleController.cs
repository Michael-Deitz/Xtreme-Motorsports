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

    [HttpGet("{id}")]
    
    public IActionResult GetVehiclesById(int id)
    {
        List<VehiclesNoNavDTO> vehicles = _dbContext.Vehicles
            .Include(v => v.Brand)
            .Include(v => v.TypeOfVehicle)
            .Include(v => v.Size)
            .Where(v => v.Id == id)
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

    [HttpGet("withusers")]

    public IActionResult GetAllVehiclesWithUsers()
    {
        List<VehiclesWithUsersDTO> vehiclesWithUsers = _dbContext.Vehicles
            .Include(v => v.Brand)
            .Include(v => v.TypeOfVehicle)
            .Include(v => v.Size)
            .Include(v => v.UserProfile)
                .ThenInclude(up => up.IdentityUser)
            .Select(v => new VehiclesWithUsersDTO
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
                UserProfileId = v.UserProfileId,
                UserProfile = new UserProfileForVehiclesDTO 
                    {
                        FirstName = v.UserProfile.FirstName,
                        LastName = v.UserProfile.LastName,
                        UserName = v.UserProfile.IdentityUser.UserName,
                        PhoneNumber = v.UserProfile.IdentityUser.PhoneNumber,
                        Email = v.UserProfile.IdentityUser.Email
                    },
                ImageUrl = v.ImageUrl

            })
            .ToList();
        
        return Ok(vehiclesWithUsers);
    }

    [HttpGet("withusers/{id}")]

    public IActionResult GetAllVehiclesWithUsersById(int id)
    {
        List<VehiclesWithUsersDTO> vehiclesWithUsers = _dbContext.Vehicles
            .Include(v => v.Brand)
            .Include(v => v.TypeOfVehicle)
            .Include(v => v.Size)
            .Include(v => v.UserProfile)
                .ThenInclude(up => up.IdentityUser)
            .Where(v => v.Id == id)
            .Select(v => new VehiclesWithUsersDTO
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
                UserProfileId = v.UserProfileId,
                UserProfile = new UserProfileForVehiclesDTO 
                    {
                        FirstName = v.UserProfile.FirstName,
                        LastName = v.UserProfile.LastName,
                        UserName = v.UserProfile.IdentityUser.UserName,
                        PhoneNumber = v.UserProfile.IdentityUser.PhoneNumber,
                        Email = v.UserProfile.IdentityUser.Email
                    },
                ImageUrl = v.ImageUrl

            })
            .ToList();
        
        return Ok(vehiclesWithUsers);
    }

    [HttpPost("create")]

    public IActionResult VehicleCreation(VehiclesToCreateDTO newVehicle)
    {
        UserProfile userProfile = _dbContext.UserProfiles.Find(newVehicle.UserProfileId);

        if(userProfile == null)
        {
            return BadRequest("Invalid UserProfileId");
        }

        Vehicles vehiclesToCreate = new Vehicles()
        {
            BrandId = newVehicle.BrandId,
            SizeId = newVehicle.SizeId,
            TypeOfVehicleId = newVehicle.TypeOfVehicleId,
            ImageUrl = newVehicle.ImageUrl,
            UserProfileId = newVehicle.UserProfileId
        };

        _dbContext.Vehicles.Add(vehiclesToCreate);
        _dbContext.SaveChanges();

        return Created($"/api/vehicle/{vehiclesToCreate.Id}", vehiclesToCreate);
    }
}