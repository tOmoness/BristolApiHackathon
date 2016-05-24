using System;
using BristolApiHackathon.ApiClient.Endpoints;
using RestSharp;

namespace BristolApiHackathon.ApiClient
{
    public class BristolApi
    {
        private string ApiUrl => $"https://bristol.api.urbanthings.io/api/{ApiVersion}/";
        private const string ApiVersion = "2.0";
        private readonly IRestClient _client;
        private readonly IRequestBuilder _requestBuilder;

        public BristolApi(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));

            _client = new RestClient(ApiUrl);
            _requestBuilder = new RequestBuilder(apiKey);

            Static = new StaticApi(_client, _requestBuilder);
            Planning = new PlanningApi(_client, _requestBuilder);
            RealTime = new RealTimeApi(_client, _requestBuilder);
        }

        public StaticApi Static { get; private set; }

        public PlanningApi Planning { get; private set; }

        public RealTimeApi RealTime { get; private set; }
    }
}
