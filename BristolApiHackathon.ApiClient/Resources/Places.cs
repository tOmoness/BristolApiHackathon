using System.Collections.Generic;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class Places : IPlaces
    {
        public IEnumerable<Models.PlacePoints> Get(string name, string placePointTypes, double lat, double lng, string countryCode, int maxResultsPerType)
        {
            throw new System.NotImplementedException();
        }
    }
}