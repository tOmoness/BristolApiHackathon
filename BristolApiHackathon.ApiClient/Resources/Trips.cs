using System.Collections.Generic;
using BristolApiHackathon.Models;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class Trips : BaseResource, ITrips
    {
        private const string Resource = "/static/trips";

        internal Trips(IRestClient client, IRequestBuilder requestBuilder) : base(Resource, client, requestBuilder)
        {
        }

        public IEnumerable<TransitTrip> Get(string routeId, string tripId, string originStopId, string destStopId, bool includePolyLines,
            bool includeStopCoordinates)
        => Get<List<TransitTrip>>(request =>
            request.AddQueryParameter("routeId", routeId)
                .AddQueryParameter("tripId", tripId)
                .AddQueryParameter("originStopId", originStopId)
                .AddQueryParameter("destStopId", destStopId)
                .AddQueryParameter("includePolyLines", includePolyLines.ToString())).Data;
    }
}