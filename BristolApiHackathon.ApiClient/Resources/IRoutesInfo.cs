using System.Collections.Generic;
using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public interface IRoutesInfo
    {
        IEnumerable<TransitDetailRouteInfo> GetByLineName(string lineName, bool exactMatch, string importSource,
            string agencyId, string agencyRegion, double lat, double lng);

        IEnumerable<TransitDetailRouteInfo> GetBySource(string agencyId, string importSource);
        IEnumerable<TransitDetailRouteInfo> GetByCallingAtStop(string stopId);
    }
}