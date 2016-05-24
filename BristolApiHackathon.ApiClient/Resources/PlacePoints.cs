using System.Collections.Generic;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class PlacePoints : IPlacePoints
    {
        public IEnumerable<PlacePoints> Get(double centerLat, double centerLng, int radius, double minLat, double minLng, double maxLat,
            double maxLng, string name, string placePointTypes, int maxResults)
        {
            throw new System.NotImplementedException();
        }
    }
}