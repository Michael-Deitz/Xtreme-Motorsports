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
public class BrandController : ControllerBase
{
    private XtremeDbContext _dbContext;

    public BrandController(XtremeDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]

    public IActionResult GetAllBrands()
    {
        return Ok(_dbContext.Brands
        .Select(b => new BrandNoNavDTO
        {
            Id = b.Id,
            Make = b.Make
        }));
    }

    [HttpGet("{id}")]

    public IActionResult GetBrandsById(int id)
    {
        return Ok(_dbContext.Brands
        .Where(b => b.Id == id)
        .Select(b => new BrandNoNavDTO
        {
            Id = b.Id,
            Make = b.Make
        }));
    }
}