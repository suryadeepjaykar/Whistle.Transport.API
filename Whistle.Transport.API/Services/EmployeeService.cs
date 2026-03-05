using Whistle.Transport.API.DTOs;
using Whistle.Transport.API.Models;
using Whistle.Transport.API.Repositories;

namespace Whistle.Transport.API.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _repository;

        //employee section
        public EmployeeService(EmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _repository.GetAllEmployees();
        }
        public async Task<Employee> AddEmployee(AddEmployeeDto req)
        {
            var employee = new Employee
            {
                Name = req.Name,
                Email = req.Email
            };

            return await _repository.AddEmployee(employee);
        }
    }
}
