using BristolApiHackathon.Models;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class Directions : BaseResource, IDirections
    {
        private const string Resource = "/plan/directions";

        internal Directions(IRestClient _client, IRequestBuilder _requestBuilder) : base(Resource, _client, _requestBuilder)
        {
        }

        public DirectionsResponse Post(DirectionsRequest directionsRequest) => Post<DirectionsResponse>(request =>
        {
            request.AddJsonBody(directionsRequest);

            return request;
        }).Data;
    }
}