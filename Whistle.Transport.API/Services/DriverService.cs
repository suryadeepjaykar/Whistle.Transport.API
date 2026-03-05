using Whistle.Transport.API.DTOs;
using Whistle.Transport.API.Models;
using Whistle.Transport.API.Repositories;

namespace Whistle.Transport.API.Services
{
    public class DriverService
    {
        private readonly DriverRepository _driverRepository;
        public DriverService(DriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }
        public async Task<List<Driver>> GetAllDrivers()
        {
            return await _driverRepository.GetAllDrivers();
        }
        public async Task<Driver> AddDriver(AddDriverDto req)
        {
            var driver = new Driver
            {
                Name = req.Name,
                Phone = req.Phone,
                LicenseNumber = req.LicenseNumber,
                VehicleId = req.VehicleId
            };

            return await _driverRepository.AddDriver(driver);
        }
    }
}
