using Whistle.Transport.API.DTOs;
using Whistle.Transport.API.Models;
using Whistle.Transport.API.Repositories;

namespace Whistle.Transport.API.Services
{
    public class RideService
    {
        private readonly RideRepository _repository;
        public RideService(RideRepository rideRepository)
        {
            _repository = rideRepository;
        }

        public async Task<List<Models.Ride>> GetAllRides()
        {
            return await _repository.GetAllRides();
        }

        public async Task<Ride> BookRide(RideRequestDto request) 
        {
            var ride = new Ride
            {
                //Id = Guid.NewGuid(),
                EmployeeId = request.EmployeeId,
                PickupLocation = request.PickupLocation,
                DropLocation = request.DropLocation,
                RideTime = DateTime.UtcNow
            };

            return await _repository.AddRide(ride);
        }
    }
}
