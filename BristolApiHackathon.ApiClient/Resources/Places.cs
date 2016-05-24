using System.Collections.Generic;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class Places : BaseResource, IPlaces
    {
        private const string Resource = "/static/places/List";

        internal Places(IRestClient client, IRequestBuilder requestBuilder) : base(Resource, client, requestBuilder)
        {
        }

        public IEnumerable<PlacePoints> Get(string name, string placePointTypes, double lat, double lng, string countryCode, int maxResultsPerType)
        => Get<List<PlacePoints>>(request =>
        {
            request.AddQueryParameter("name", name);
            request.AddQueryParameter("placepointtypes", placePointTypes);
            request.AddQueryParameter("lat", lat.ToString());
            request.AddQueryParameter("lng", lng.ToString());
            request.AddQueryParameter("countryCode", countryCode);
            request.AddQueryParameter("maxResultsPerType", maxResultsPerType.ToString());

            return request;
        }).Data;
    }
}