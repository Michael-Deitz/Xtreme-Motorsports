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
public class WorkOrderController : ControllerBase
{
    private XtremeDbContext _dbContext;

    public WorkOrderController(XtremeDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]

    public IActionResult GetAllWorkOrders()
    {
        List<WorkOrder> workOrders = _dbContext.WorkOrders
            .Include(wo => wo.Vehicles)
            .Select(wo => new WorkOrder
            {
                Id = wo.Id,
                Description = wo.Description,
                VehiclesId = wo.VehiclesId,
                Vehicles = new Vehicles
                {
                    Id = wo.Vehicles.Id,
                    Brand = wo.Vehicles.Brand,
                    TypeOfVehicle = wo.Vehicles.TypeOfVehicle,
                    Size = wo.Vehicles.Size,
                    UserProfile = wo.Vehicles.UserProfile,
                    ImageUrl = wo.Vehicles.ImageUrl,
                }
            }).ToList();

        return Ok(workOrders);
    }



}