using Whistle.Transport.API.Models;
using Whistle.Transport.API.Repositories;

namespace Whistle.Transport.API.Services
{
    public class RideStatusService
    {
        private readonly RideRepository _repository;
        public RideStatusService(RideRepository repository) 
        {
            _repository = repository;
        }
        public async Task<Ride> StartRide(int rideId)
        {
            var ride = await _repository.GetRideById(rideId);
            if (ride != null)
            {
                ride.Status = RideStatus.Started;
                await _repository.UpdateRide(ride);
                return ride;
            }
            else
            {
                throw new Exception("Unable to Start/Get Ride");
            }
        }
        public async Task<Ride> CompleteRide(int rideId)
        {
            var ride = await _repository.GetRideById(rideId);
            if (ride != null)
            {
                ride.Status = RideStatus.Completed;
                await _repository.UpdateRide(ride);
                return ride;
            }
            else
            {
                throw new Exception("Unable to Get/Complete Ride");
            }
            
        }
        public async Task<Ride> AssignRide(int rideId)
        {
            var ride = await _repository.GetRideById(rideId);

            ride.Status = RideStatus.Assigned;

            await _repository.UpdateRide(ride);

            return ride;
        }

        public async Task<Ride> CancelRide(int rideId)
        {
            var ride = await _repository.GetRideById(rideId);

            ride.Status = RideStatus.Cancelled;

            await _repository.UpdateRide(ride);

            return ride;
        }
    }
}
