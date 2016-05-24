using System.Collections.Generic;
using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public interface IAgencies
    {
        IEnumerable<TransitAgency> Get(string agencyId, string importSource);
    }
}