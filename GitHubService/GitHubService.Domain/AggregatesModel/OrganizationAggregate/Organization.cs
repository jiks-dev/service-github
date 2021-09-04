using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubService.Domain.AggregatesModel.OrganizationAggregate
{
    public class Organization
    {
        public string login { get; set; }
        public string url { get; set; }
        public string repos_url { get; set; }
        public string members_url { get; set; }
        public string avatar_url { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public int public_repos { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public override string ToString() {
            return $"login={login}, url={url}, description={description}, name={name}, " +
                $"public_repos={public_repos}, create_at={created_at}, updated_at={updated_at}";
        }
    }
}
