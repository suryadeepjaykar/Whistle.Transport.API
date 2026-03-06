using Microsoft.AspNetCore.Mvc;
using Whistle.Transport.API.DTOs;
using Whistle.Transport.API.Services;

namespace Whistle.Transport.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DriverController:ControllerBase
    {
        private readonly DriverService _driverService;
        public DriverController(DriverService driverService)
        {
                _driverService = driverService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDrivers() 
        {
            var drivers = await _driverService.GetAllDrivers();
            return Ok(drivers);
        }
        [HttpPost]
        public async Task<IActionResult> AddDriver(AddDriverDto req)
        {
            var driver = await _driverService.AddDriver(req);
            return Ok(driver);
        }
    }
}
