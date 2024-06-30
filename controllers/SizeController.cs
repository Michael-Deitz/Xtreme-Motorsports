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
public class SizeController : ControllerBase
{
    private XtremeDbContext _dbContext;

    public SizeController(XtremeDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]

    public IActionResult GetAllSizes()
    {
        return Ok(_dbContext.Sizes
        .Select(s => new SizeNoNavDTO
        {
            Id = s.Id,
            CubicCentimeters = s.CubicCentimeters
        }));
    }

}