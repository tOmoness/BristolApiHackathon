using System.Collections.Generic;

namespace BristolApiHackathon.ApiClient.Resources
{
    public interface IPlacePoints
    {
        IEnumerable<PlacePoints> Get(double centerLat, double centerLng, int radius, double minLat, double minLng,
            double maxLat, double maxLng, string name, string placePointTypes, int maxResults);
    }
}