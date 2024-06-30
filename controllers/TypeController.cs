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
}