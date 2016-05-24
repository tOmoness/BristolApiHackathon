using System.Collections.Generic;
using BristolApiHackathon.Models;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class TransitStops : BaseResource, ITransitStops
    {
        private const string Resource = "/static/transitstops";
        internal TransitStops(IRestClient client, IRequestBuilder requestBuilder) : base(Resource, client, requestBuilder)
        {
        }

        public IEnumerable<TransitStop> Get(double minLat, double maxLat, double minLng, double maxLng, double centerLat,
            double centerLng, double radius, int maxResults, string stopModes, string stopName, string stopIds,
            string importSource)
        => Get<List<TransitStop>>(request => 
            request.AddQueryParameter("minLat", minLat.ToString())
                .AddQueryParameter("maxLat", maxLat.ToString())
                .AddQueryParameter("minLng", minLng.ToString())
                .AddQueryParameter("maxLng", maxLng.ToString())
                .AddQueryParameter("centerLat", centerLat.ToString())
                .AddQueryParameter("centerLng", centerLng.ToString())
                .AddQueryParameter("radius", radius.ToString())
                .AddQueryParameter("maxResults", maxResults.ToString())
                .AddQueryParameter("stopModes", stopModes)
                .AddQueryParameter("stopName", stopName)
                .AddQueryParameter("stopIds", stopIds)).Data;
    }
}