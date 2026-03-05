using Microsoft.EntityFrameworkCore;
using Whistle.Transport.API.Models;


namespace Whistle.Transport.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Ride> Rides { get; set; }
    }
}
