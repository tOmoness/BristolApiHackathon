using BristolApiHackathon.Models;
using RestSharp;
using System;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class BaseResource
    {
        private readonly string _resource;
        private readonly IRestClient _client;
        private readonly IRequestBuilder _requestBuilder;

        internal BaseResource(string resource, IRestClient client, IRequestBuilder requestBuilder)
        {
            if (string.IsNullOrWhiteSpace(resource)) throw new ArgumentNullException(nameof(resource));
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (requestBuilder == null) throw new ArgumentNullException(nameof(requestBuilder));

            _resource = resource;
            _client = client;
            _requestBuilder = requestBuilder;
        }

        protected ApiResponse<T> Get<T>(Func<IRestRequest, IRestRequest> addArguments = null) where T : new()
        {
            var request = _requestBuilder.Get(_resource);

            if (addArguments != null) request = addArguments(request);

            var response = _client.Get<ApiResponse<T>>(request);

            return response.Data;
        }

        protected ApiResponse<T> Post<T>(Func<IRestRequest, IRestRequest> addArguments = null) where T : new()
        {
            var request = _requestBuilder.Post(_resource);

            if (addArguments != null) request = addArguments(request);

            var response = _client.Post<ApiResponse<T>>(request);

            return response.Data;
        }
    }
}
