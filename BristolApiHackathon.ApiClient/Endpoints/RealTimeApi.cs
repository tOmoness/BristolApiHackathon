using System;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Endpoints
{
    public class RealTimeApi
    {
        private readonly IRestClient _client;
        private readonly string _apiKey;

        public RealTimeApi(IRestClient client, string apiKey)
        {
            if (client == null) throw new ArgumentNullException(nameof(_client));
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));

            _client = client;
            _apiKey = apiKey;
        }
    }
}
