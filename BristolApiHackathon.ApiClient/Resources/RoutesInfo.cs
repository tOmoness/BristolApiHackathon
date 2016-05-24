using System.Collections.Generic;
using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class RoutesInfo : IRoutesInfo
    {
        public IEnumerable<TransitDetailRouteInfo> GetByLineName(string lineName, bool exactMatch, string importSource, string agencyId, string agencyRegion,
            double lat, double lng)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TransitDetailRouteInfo> GetBySource(string agencyId, string importSource)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TransitDetailRouteInfo> GetByCallingAtStop(string stopId)
        {
            throw new System.NotImplementedException();
        }
    }
}