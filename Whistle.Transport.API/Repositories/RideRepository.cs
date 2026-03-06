using Microsoft.EntityFrameworkCore;
using Whistle.Transport.API.Data;
using Whistle.Transport.API.Models;

namespace Whistle.Transport.API.Repositories
{
    public class RideRepository
    {
        private readonly AppDbContext _context;

        public RideRepository(AppDbContext context)
        {
            _context = context;
        }
        //get all rides
        public async Task<List<Ride>> GetAllRides()
        {
            return await _context.Rides.ToListAsync();
        }
        //Add ride
        public async Task<Ride> AddRide(Ride ride)
        {
            _context.Rides.Add(ride);
            await _context.SaveChangesAsync();
            return ride;
        }
        //getride by id
        public async Task<Ride> GetRideById(int id)
        {
            return await _context.Rides.FindAsync(id);
        }
        //update ride
        public async Task<Ride> UpdateRide(Ride ride)
        {
            _context.Rides.Update(ride);
            await _context.SaveChangesAsync();
            return ride;
        }
    }
}
