using System;
using BristolApiHackathon.ApiClient.Endpoints;
using BristolApiHackathon.Models;
using RestSharp;

namespace BristolApiHackathon.ApiClient
{
    public class BristolApi
    {
        private string ApiUrl => $"https://bristol.api.urbanthings.io/api/{ApiVersion}/";
        private const string ApiVersion = "2.0";
        private readonly string _apiKey;
        private readonly IRestClient _client;

        public BristolApi(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));
            _apiKey = apiKey;

            _client = BuildClient();

            Static = new StaticApi(_client, _apiKey);
            Planning = new PlanningApi(_client, _apiKey);
        }

        private IRestClient BuildClient() => new RestClient(ApiUrl);

        public StaticApi Static { get; private set; }

        public PlanningApi Planning { get; private set; }
    }
}
