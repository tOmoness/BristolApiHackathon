using System;
using RestSharp;

namespace BristolApiHackathon.ApiClient
{
    internal class RequestBuilder : IRequestBuilder
    {
        private readonly string _apiKey;

        internal RequestBuilder(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));

            _apiKey = apiKey;
        }

        private IRestRequest CreateBaseRequest(string resource, Method method)
        {
            if (string.IsNullOrWhiteSpace(resource)) throw new ArgumentNullException(nameof(resource));

            var request = new RestRequest(resource, method);

            request.AddHeader("X-Api-Key", _apiKey);

            return request;
        }

        public IRestRequest Get(string resource) => CreateBaseRequest(resource, Method.GET);

        public IRestRequest Post(string resource) => CreateBaseRequest(resource, Method.POST);
    }
}
