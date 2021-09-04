using GitHubService.Domain.AggregatesModel.OrganizationAggregate;
using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitHubService.API.Services.OrganizationService
{
    public class OrganizationService : IOrganizationService
    {
        private readonly ILogger<OrganizationService> _logger;
        
        private const string githubUri = "https://api.github.com";

        public OrganizationService(ILogger<OrganizationService> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Call organization infroamtion from github api
        /// </summary>
        /// <returns>Organization Inforamtion</returns>
        public Organization GetOrganizationInformation(string name)
        {
            var client = new RestClient(githubUri);
            var request = new RestRequest($"orgs/{name}", Method.GET);
            var response = client.Execute<Organization>(request);

            _logger.LogInformation($"Call Organizaiton {name} information get data >> {response.Data}");

            return response.Data;
        }
    }
}
