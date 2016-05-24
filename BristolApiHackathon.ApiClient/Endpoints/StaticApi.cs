using System;
using BristolApiHackathon.ApiClient.Resources;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Endpoints
{
    public class StaticApi
    {
        internal StaticApi(IRestClient client, IRequestBuilder requestBuilder)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (requestBuilder == null) throw new ArgumentNullException(nameof(requestBuilder));

            Agencies = new Agencies(client, requestBuilder);
            ImportSources = new ImportSources(client, requestBuilder);
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