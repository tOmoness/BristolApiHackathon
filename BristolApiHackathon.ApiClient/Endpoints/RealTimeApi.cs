using System;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Endpoints
{
    public class RealTimeApi
    {
        private readonly IRestClient _client;
        private readonly IRequestBuilder _requestBuilder;

        internal RealTimeApi(IRestClient client, IRequestBuilder requestBuilder)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (requestBuilder == null) throw new ArgumentNullException(nameof(requestBuilder));

            _client = client;
            _requestBuilder = requestBuilder;
        }
    }
}
