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
        public async Task<List<Ride>> GetAllRides()
        {
            return await _context.Rides.ToListAsync();
        }
        public async Task<Ride> AddRide(Ride ride)
        {
            _context.Rides.Add(ride);
            await _context.SaveChangesAsync();
            return ride;
        }
    }
}
