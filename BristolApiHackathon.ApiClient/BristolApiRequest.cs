using System.Reflection;
using BristolApiHackathon.Models;
using RestSharp;

namespace BristolApiHackathon.ApiClient
{
    public class BristolApiRequest : RestRequest
    {
        private BristolApiRequest(string resource, Method method) : base(resource, method)
        {
        }

        public static BristolApiRequest CreateDirectionsRequest(DirectionsRequest directionsRequest)
            => new BristolApiRequest("/plan/directions", Method.POST).AddJsonBody(directionsRequest) as BristolApiRequest;

        public static BristolApiRequest CreateAgenciesRequest(string agencyId = null, string importSource = null)
            =>
                new BristolApiRequest("/static/agencies", Method.GET).AddQueryParameter("agencyid", agencyId)
                    .AddQueryParameter("importsource", importSource) as BristolApiRequest;
        
    }
}