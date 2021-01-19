using Company.Employees.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Company.Employees.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static readonly Employee[] SampleData = {
           new Employee
               {
                   EmployeeId = 1,
                   OrganisationNumber = "09740322",
                   FirstName = "Janet",
                   LastName = "Smith"
               },
           new Employee
               {
                   EmployeeId = 13,
                   OrganisationNumber = "00002065",
                   FirstName = "Mitch",
                   LastName = "Krause"
               }
        };

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return SampleData;
        }
    }
}
