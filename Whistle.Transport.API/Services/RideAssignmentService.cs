using Whistle.Transport.API.Models;
using Whistle.Transport.API.Repositories;

namespace Whistle.Transport.API.Services
{
    public class RideAssignmentService
    {
        private readonly DriverRepository _driverRepository;
        private readonly RideRepository _rideRepository;
        public RideAssignmentService(DriverRepository driverRepository,
            RideRepository rideRepository)
        {
            _driverRepository = driverRepository;
            _rideRepository = rideRepository;
        }

        public async Task<Ride> AssignRide(int rideId) 
        {
            var ride = await _rideRepository.GetRideById(rideId);   
            var driver = await _driverRepository.GetAvailableDriver();

            if (ride != null && driver != null)
            {
                ride.DriverId = driver.Id;
                ride.Status = RideStatus.Assigned;
                ride.VehicleId = driver.VehicleId;
                await _rideRepository.UpdateRide(ride);
                return ride;
            }
            else 
            {
                throw new Exception("No drivers available");
            }
        }
    }
}
