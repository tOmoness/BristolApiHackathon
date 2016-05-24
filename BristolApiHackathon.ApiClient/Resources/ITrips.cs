using System.Collections.Generic;
using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public interface ITrips
    {
        IEnumerable<TransitTrip> Get(string routeId, string tripId, string originStopId, string destStopId,
            bool includePolyLines, bool includeStopCoordinates);
    }
}