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
    [Authorize]
    public IActionResult GetAllWorkOrders()
    {
        List<WorkOrder> workOrders = _dbContext.WorkOrders
            .Include(wo => wo.Vehicles)
                .ThenInclude(v => v.UserProfile)
                    .ThenInclude(up => up.IdentityUser)
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

    [HttpPost("create")]
    [Authorize]
    public IActionResult CreateWorkOrder(WorkOrderCreate newWO)
    {
        WorkOrder WorkOrderCreate = new WorkOrder()
        {
            Description = newWO.Description,
            VehiclesId = newWO.VehiclesId
        };

        _dbContext.WorkOrders.Add(WorkOrderCreate);
        _dbContext.SaveChanges();

        return Created($"/api/workorder/{WorkOrderCreate.Id}", WorkOrderCreate);
    }



}