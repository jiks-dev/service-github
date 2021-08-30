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
        private readonly ILogger<OrganizationController> _logger;

        public OrganizationController(ILogger<OrganizationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Index()
        {
            return "Hello Organization";
        }
    }
}
