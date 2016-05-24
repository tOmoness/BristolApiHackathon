using System.Collections.Generic;
using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class TransitStops : ITransitStops
    {
        public IEnumerable<TransitStop> Get(double minLat, double maxLat, double minLng, double maxLng, double centerLat,
            double centerLng, double radius, int maxResults, string stopModes, string stopName, string stopIds,
            string importSource)
        {
            throw new System.NotImplementedException();
        }
    }
}