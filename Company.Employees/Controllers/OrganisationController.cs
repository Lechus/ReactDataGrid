using Company.Employees.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Company.Employees.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrganisationController : ControllerBase
    {
        private static readonly Organisation[] SampleData = {
           new Organisation
               {
                   OrganisationId = 1,
                   OrganisationName = "Barclays UK PLC",
                   OrganisationNumber = "09740322",
                   AddressLine1 = "1 Churchill Place",
                   AddressLine2 = "",
                   AddressLine3 = "",
                   AddressLine4 = "",
                   Town = "London",
                   Postcode = "E14 5HP",
                   House = "12",
               },
           new Organisation
               {
                   OrganisationId = 2,
                   OrganisationName = "HSBC BANK PLC",
                   OrganisationNumber = "00014259",
                   AddressLine1 = "8 Canada Square",
                   AddressLine2 = "",
                   AddressLine3 = "",
                   AddressLine4 = "",
                   Town = "London",
                   Postcode = "E14 5HQ",
                   House = "8",
               }
        };

        private readonly ILogger<OrganisationController> _logger;

        public OrganisationController(ILogger<OrganisationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Organisation> Get()
        {
            return SampleData;
        }
    }
}
