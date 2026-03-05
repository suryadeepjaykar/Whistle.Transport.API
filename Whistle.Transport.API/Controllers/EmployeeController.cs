using Microsoft.AspNetCore.Mvc;
using Whistle.Transport.API.DTOs;
using Whistle.Transport.API.Services;

namespace Whistle.Transport.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController:ControllerBase
    {
        EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService)
        {
                _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeeService.GetAllEmployees();
            return Ok(employees);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(AddEmployeeDto req)
        {
            var employee = await _employeeService.AddEmployee(req);
            return Ok(employee);
        }
    }
}
