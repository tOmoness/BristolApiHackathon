using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BristolApiHackathon.ApiClient
{
    public class BristolApi
    {
        private string ApiUrl => $"https://bristol.api.urbanthings.io/api/{ApiVersion}/";
        private const string ApiVersion = "2.0";
        private readonly string _apiKey;

        public BristolApi(string apiKey)
        {
            if (apiKey == null) throw new ArgumentNullException(nameof(apiKey));
            _apiKey = apiKey;
        }
    }
}
