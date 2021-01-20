using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Company.Employees.Controllers
{
    using System.Linq;

    using Company.Employees.Database;

    using Organisation = Company.Employees.Models.Organisation;

    [ApiController]
    [Route("api/[controller]")]
    public class OrganisationController : ControllerBase
    {
        private readonly ILogger<OrganisationController> _logger;

        private readonly OrganisationsDbContext _dbContext;

        public OrganisationController(ILogger<OrganisationController> logger, OrganisationsDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Organisation> Get()
        {
            return _dbContext.Organisations.Select(x=> new Organisation(x)).ToList();
        }
    }
}
