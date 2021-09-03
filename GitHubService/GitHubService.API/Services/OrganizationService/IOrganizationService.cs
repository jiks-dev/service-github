using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubService.API.Services.OrganizationService
{
    public interface IOrganizationService
    {
        public Domain.AggregatesModel.OrganizationAggregate.Organization Get(string name);
    }
}
