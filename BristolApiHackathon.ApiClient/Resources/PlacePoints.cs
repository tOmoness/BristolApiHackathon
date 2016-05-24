using System.Collections.Generic;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class PlacePoints : BaseResource, IPlacePoints
    {
        private const string Resource = "/static/placepoints";

        internal PlacePoints(IRestClient client, IRequestBuilder requestBuilder) : base(Resource, client, requestBuilder)
        {
        }

        public IEnumerable<PlacePoints> Get(double centerLat, double centerLng, int radius, double minLat, double minLng, double maxLat,
            double maxLng, string name, string placePointTypes, int maxResults)
        => Get<List<PlacePoints>>(request =>
        {
            request.AddQueryParameter("centerlat", centerLat.ToString());
            request.AddQueryParameter("centerlng", centerLng.ToString());
            request.AddQueryParameter("radius", radius.ToString());
            request.AddQueryParameter("minlat", minLat.ToString());
            request.AddQueryParameter("minlng", minLng.ToString());
            request.AddQueryParameter("maxlat", maxLat.ToString());
            request.AddQueryParameter("maxlng", maxLng.ToString());
            request.AddQueryParameter("name", name);
            request.AddQueryParameter("placepointtypes", placePointTypes);
            request.AddQueryParameter("maxResults", maxResults.ToString());

            return request;
        }).Data;
    }
}