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
public class TypeOfVehicleController : ControllerBase
{
    private XtremeDbContext _dbContext;

    public TypeOfVehicleController(XtremeDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]

    public IActionResult GetAllTypes()
    {
        return Ok(_dbContext.TypeOfVehicles
        .Select(t => new TypeNoNavDTO
        {
            Id = t.Id,
            Type = t.Type
        }));
    }

    [HttpGet("{id}")]

    public IActionResult GetTypesById(int id)
    {
        return Ok(_dbContext.TypeOfVehicles
        .Where(t => t.Id == id)
        .Select(t => new TypeNoNavDTO
        {
            Id = t.Id,
            Type = t.Type
        }));
    }

    [HttpPost("create")]

    public IActionResult TypeCreation(TypeCreateDTO newType)
    {
        UserProfile userProfile = _dbContext.UserProfiles.Find(newType.UserProfileId);

        if(userProfile == null)
        {
            return BadRequest("Invalid UserProfileId");
        }

        TypeOfVehicle TypeToCreate = new TypeOfVehicle()
        {
            Type = newType.Type
        };

        _dbContext.TypeOfVehicles.Add(TypeToCreate);
        _dbContext.SaveChanges();

        return Created($"/api/type/{TypeToCreate.Id}", TypeToCreate);
    }
}