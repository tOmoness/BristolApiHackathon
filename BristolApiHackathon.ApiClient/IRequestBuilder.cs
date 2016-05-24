using RestSharp;

namespace BristolApiHackathon.ApiClient
{
    internal interface IRequestBuilder
    {
        IRestRequest Get(string resource);

        IRestRequest Post(string resource);
    }
}