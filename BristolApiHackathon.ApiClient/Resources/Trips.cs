using System.Collections.Generic;
using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class Trips : ITrips
    {
        public IEnumerable<TransitTrip> Get(string routeId, string tripId, string originStopId, string destStopId, bool includePolyLines,
            bool includeStopCoordinates)
        {
            throw new System.NotImplementedException();
        }
    }
}