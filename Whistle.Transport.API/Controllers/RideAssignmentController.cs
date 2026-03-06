using Microsoft.AspNetCore.Mvc;
using Whistle.Transport.API.Services;

namespace Whistle.Transport.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RideAssignmentController : ControllerBase
    {
        private readonly RideAssignmentService _rideAssignmentService;
        public RideAssignmentController(RideAssignmentService rideAssignmentService)
        {
            _rideAssignmentService = rideAssignmentService;
        }
        [HttpPut("{rideId}/assign")]
        public async Task<IActionResult> AssignRide(int rideId)
        {
            var ride = await _rideAssignmentService.AssignRide(rideId);
            return Ok(ride);
        }

    }
}
