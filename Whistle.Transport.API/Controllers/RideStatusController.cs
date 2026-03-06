using Microsoft.AspNetCore.Mvc;
using Whistle.Transport.API.Services;

namespace Whistle.Transport.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RideStatusController : ControllerBase
    {
        private readonly RideStatusService _rideStatusService;
        public RideStatusController(RideStatusService rideStatusService)
        {
            _rideStatusService = rideStatusService;
        }
        //[HttpPut("{rideId}/assign")]
        //public async Task<IActionResult> AssignRide(int rideId)
        //{
        //    var ride = await _rideStatusService.AssignRide(rideId);
        //    return Ok(ride);
        //}

        [HttpPut("{rideId}/start")]
        public async Task<IActionResult> StartRide(int rideId)
        {
            var ride= await _rideStatusService.StartRide(rideId);
            if (ride == null)
            {
                return NotFound();
            }
            return Ok(ride);
        }

        [HttpPut("{rideId}/complete")]
        public async Task<IActionResult> CompleteRide(int rideId)
        {
            var ride = await _rideStatusService.CompleteRide(rideId);
            if (ride == null)
            {
                return NotFound();
            }
            return Ok(ride);
        }

        [HttpPut("{rideId}/cancel")]
        public async Task<IActionResult> CancelRide(int rideId)
        {
            var ride = await _rideStatusService.CancelRide(rideId);
            return Ok(ride);
        }
    }
}
