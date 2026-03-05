using Microsoft.AspNetCore.Mvc;
using Whistle.Transport.API.DTOs;
using Whistle.Transport.API.Services;

namespace Whistle.Transport.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleService _vehicleService;
        public VehicleController(VehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllVehicles()
        {
            var vehicles = await _vehicleService.GetAllVehicles();
            return Ok(vehicles);
        }
        //[HttpPost("AddVehicle")]
        [HttpPost]
        public async Task<IActionResult> AddVehicle(AddVehicleDto req)
        {
            var vehicle = await _vehicleService.AddVehicle(req);
            return Ok(vehicle);
        }
    }
}
