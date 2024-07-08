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

    [HttpGet("{id}")]

    public IActionResult GetSizesById(int id)
    {
        return Ok(_dbContext.Sizes
        .Where(s => s.Id == id)
        .Select(s => new SizeNoNavDTO
        {
            Id = s.Id,
            CubicCentimeters = s.CubicCentimeters
        }));
    }

    [HttpPost("create")]

    public IActionResult SizeCreation(SizeCreateDTO newSize)
    {
        UserProfile userProfile = _dbContext.UserProfiles.Find(newSize.UserProfileId);

        if(userProfile == null)
        {
            return BadRequest("Invalid UserProfileId");
        }

        Size SizeToCreate = new Size()
        {
            CubicCentimeters = newSize.CubicCentimeters
        };

        _dbContext.Sizes.Add(SizeToCreate);
        _dbContext.SaveChanges();

        return Created($"/api/size/{SizeToCreate.Id}", SizeToCreate);
    }
}