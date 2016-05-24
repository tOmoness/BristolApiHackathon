using System.Collections.Generic;
using BristolApiHackathon.Models;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class Agencies : BaseResource, IAgencies
    {
        private const string Resource = "/static/agencies";
        internal Agencies(IRestClient client, IRequestBuilder requestBuilder) : base(Resource, client, requestBuilder)
        {
        }

        public IEnumerable<TransitAgency> Get(string agencyId, string importSource)
            => Get<List<TransitAgency>>(request =>
            {
                if (!string.IsNullOrWhiteSpace(agencyId)) request.AddQueryParameter("agencyId", agencyId);
                if (!string.IsNullOrWhiteSpace(importSource)) request.AddQueryParameter("importSource", importSource);
                return request;
            }).Data;
    }
}