using GitHubService.API.Services.OrganizationService;
using GitHubService.Domain.AggregatesModel.OrganizationAggregate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubService.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class OrganizationController : Controller
    {
        private readonly ILogger<OrganizationController> _logger = null;
        private readonly IOrganizationService _organizationService = null;

        public OrganizationController(
            ILogger<OrganizationController> logger, 
            IOrganizationService organizationService)
        {
            _logger = logger;
            _organizationService = organizationService;
        }

        /// <summary>
        /// Retrieves a github organization information
        /// </summary>
        /// <example>jiks-dev</example>
        /// <returns></returns>
        [HttpGet("{name}")]
        public Organization GetOrganizationInformation(string name)
        {
            return _organizationService.Get(name);
        }
    }
}
