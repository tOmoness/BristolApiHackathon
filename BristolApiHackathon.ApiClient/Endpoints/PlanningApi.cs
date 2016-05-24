using System;
using BristolApiHackathon.ApiClient.Resources;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Endpoints
{
    public class PlanningApi
    {
        private readonly IRestClient _client;
        private readonly IRequestBuilder _requestBuilder;

        internal PlanningApi(IRestClient client, IRequestBuilder requestBuilder)
        {
            if (client == null) throw new ArgumentNullException(nameof(_client));
            if (requestBuilder == null) throw new ArgumentNullException(nameof(requestBuilder));

            _client = client;
            _requestBuilder = requestBuilder;

            Directions = new Directions(_client, _requestBuilder);
        }

        public IDirections Directions { get; set; }
    }
}