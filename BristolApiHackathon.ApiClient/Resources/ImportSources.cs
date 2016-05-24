using System.Collections.Generic;
using BristolApiHackathon.Models;
using RestSharp;

namespace BristolApiHackathon.ApiClient.Resources
{
    public class ImportSources : BaseResource, IImportSources
    {
        private const string Resource = "/static/importsources";

        internal ImportSources(IRestClient client, IRequestBuilder requestBuilder) : base(Resource, client, requestBuilder)
        {
        }

        public IEnumerable<ImportSource> Get() => Get<List<ImportSource>>().Data;
    }
}