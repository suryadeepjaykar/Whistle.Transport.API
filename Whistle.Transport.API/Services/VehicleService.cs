using Whistle.Transport.API.DTOs;
using Whistle.Transport.API.Models;
using Whistle.Transport.API.Repositories;

namespace Whistle.Transport.API.Services
{
    public class VehicleService
    {
        private readonly VehicleRepository _repository;
        public VehicleService(VehicleRepository repository)
        {
            _repository = repository;
        }
        //vehicle section
        public async Task<List<Vehicle>> GetAllVehicles()
        {
            return await _repository.GetAllVehicles();
        }

        public async Task<Vehicle> AddVehicle(AddVehicleDto req)
        {
            var vehicle = new Vehicle
            {
                VehicleNumber = req.VehicleNumber,
                Capacity = req.Capacity
            };

            return await _repository.AddVehicle(vehicle);
        }
    }
}
