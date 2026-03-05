using Microsoft.AspNetCore.Mvc;
using Whistle.Transport.API.DTOs;
using Whistle.Transport.API.Services;

namespace Whistle.Transport.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RideController : ControllerBase
    {
        private readonly RideService _rideService;
        public RideController(RideService rideService)
        {
            _rideService = rideService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRides()
        {
            var rides = await _rideService.GetAllRides();
            return Ok(rides);
        }
        [HttpPost("book")]
        public async Task<IActionResult> BookRide(RideRequestDto request)
        {
            var ride = await _rideService.BookRide(request);
            return Ok(ride);
            //var response = new DTOs.RideResponseDto
            //{
            //    RideId = ride.Id,
            //    PickupLocation = ride.PickupLocation,
            //    DropLocation = ride.DropLocation
            //};
            //return Ok(response);
        }
    }
}
