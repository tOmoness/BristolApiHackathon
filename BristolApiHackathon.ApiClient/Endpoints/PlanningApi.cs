using System;
using BristolApiHackathon.ApiClient.Resources;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Endpoints
{
    public class PlanningApi
    {
        private readonly IRestClient _client;
        private readonly string _apiKey;

        public PlanningApi(IRestClient client, string apiKey)
        {
            if (client == null) throw new ArgumentNullException(nameof(_client));
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));

            _client = client;
            _apiKey = apiKey;
        }

        public Directions Directions { get; set; }
    }
}