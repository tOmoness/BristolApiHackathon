using System;
using BristolApiHackathon.ApiClient.Resources;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Endpoints
{
    public class StaticApi
    {
        private readonly IRestClient _client;
        private readonly string _apiKey;

        public StaticApi(IRestClient client, string apiKey)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));

            _client = client;
            _apiKey = apiKey;
        }

        public IImportSources ImportSources { get; private set; }
        public ITransitStops TransitStops { get; private set; }
        public IPlacePoints PlacePoints { get; private set; }
        public IPlaces Places { get; private set; }
        public IRoutesInfo RoutesInfo { get; private set; }
        public IAgencies Agencies { get; private set; }
        public ITrips Trips { get; private set; }
        public IStopCalls StopCalls { get; private set; }
        public ITripGroups TripGroups { get; private set; }
    }
}