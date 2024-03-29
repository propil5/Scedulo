using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scedulo.Server.Services.Employees;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scedulo.Server.Data.Entities.ApplicationUsers;
using Scedulo.Shared.Models.Employees;
using Scedulo.Server.Data.Entities.Employees;
using Scedulo.Shared.Models.Base;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace CalendaroNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class EmployeesController : Controller
    {

        private readonly IEmployeesService _employeeService;
        private readonly UserManager<ApplicationUser>  _userManager;
        private readonly string userId;

        public EmployeesController(IEmployeesService EmployeeService, IHttpContextAccessor httpContextAccessor)
        {
            _employeeService = EmployeeService;
            userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        // GET api/employees
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Employees = await _employeeService.GetListOfAllEmployeesAsync();
            return Ok(Employees); 
        }

        // GET api/employees/714921f1-8e4d-4d8f-a28c-3544f92e318
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var employee = await _employeeService.GetEmployeeAsync(id);      
            return Ok(employee);
        }

        // POST api/employees
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody]AddEmployeeViewModel newEmployee)
        {
            if (!ModelState.IsValid)
            {
                var modelErrors = new List<string>();
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var modelError in modelState.Errors)
                    {
                        modelErrors.Add(modelError.ErrorMessage);
                    }
                }
                return BadRequest(new AddingResult { Successful = false, Errors = modelErrors });
            }
            var employedUser = await _userManager.FindByIdAsync(userId);
            //if (currentUser == null) return Challenge();
            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                User = employedUser,
                EmploymentDate = newEmployee.EmploymentDate,
                ContractEndDate = newEmployee.ContractEndDate,
                CreatedDate = DateTimeOffset.Now,
                AddedById = userId,
                BaseMonthSalary = newEmployee.BaseMonthSalary,
            };

            var successful = await _employeeService.AddEmployeeAsync(employee);
            if (!successful)
            {
                return BadRequest("Could not add employee.");
            }
            return Ok(employee);
        }

        // PUT api/employees/714921f1-8e4d-4d8f-a28c-3544f92e318
        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEmployee(string id,[FromBody]AddEmployeeViewModel updatedEmployee)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var employedUser = await _userManager.FindByIdAsync(updatedEmployee.UserId);
            if (currentUser == null) return Challenge();

            var successful = await _employeeService
            .UpdateEmployeeAsync(id, updatedEmployee, currentUser.Id.ToString());

            if (!successful)
            {
                return BadRequest("Could not update employee.");
            }

            return Ok("Updated employee of id: " + id);
        }

        // DELETE api/employees/714921f1-8e4d-4d8f-a28c-3544f92e318
        [ValidateAntiForgeryToken]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(string id)
        {
            if (id == Guid.Empty.ToString())
            {
                return BadRequest("No parameter");
            }
            var employee = await _employeeService.GetEmployeeAsync(id);
            var name = employee.FirstName + " " + employee.Surname;
            var successful = await _employeeService.DeleteEmployeeAsync(id);
            if (!successful)
            {
                return BadRequest("Could not delete employee with name: " + name);
            }

            return Ok("Deleted user " + name);
        }

    }
}