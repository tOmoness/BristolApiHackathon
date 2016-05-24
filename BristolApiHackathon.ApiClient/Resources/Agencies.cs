using System.Collections.Generic;
using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class Agencies : IAgencies
    {
        public IEnumerable<TransitAgency> Get(string agencyId, string importSource)
        {
            throw new System.NotImplementedException();
        }
    }
}