using Microsoft.EntityFrameworkCore;
using Whistle.Transport.API.Data;
using Whistle.Transport.API.Models;

namespace Whistle.Transport.API.Repositories
{
    public class VehicleRepository
    {
        private readonly AppDbContext _context;
        public VehicleRepository(AppDbContext context)
        {
            _context= context;
        }
        //get all cabs/vehicles
        public async Task<List<Vehicle>> GetAllVehicles()
        {
            return await _context.Vehicles.ToListAsync();
        }
        //add vehicle
        public async Task<Vehicle> AddVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }
    }
}
