using Microsoft.EntityFrameworkCore;
using Whistle.Transport.API.Data;
using Whistle.Transport.API.Models;

namespace Whistle.Transport.API.Repositories
{
    public class DriverRepository
    {
        private readonly AppDbContext _context;

        public DriverRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Driver>> GetAllDrivers()
        {
            return await _context.Drivers.ToListAsync();
        }
        public async Task<Driver> AddDriver(Driver driver)
        {
            _context.Drivers.Add(driver);
            await _context.SaveChangesAsync();
            return driver;
        }
    }
}
