using System.Configuration;
using BristolApiHackathon.ApiClient;
using BristolApiHackathon.Models;

namespace BristolApiHackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiKey = ConfigurationManager.AppSettings["ApiKey"];

            var client = new ApiClient.BristolApi(apiKey);

            var request = BristolApiRequest.CreateDirectionsRequest(new DirectionsRequest
            {
                Origin = new Origin(),
                Destination = new Destination()
            });

            var response = client.Send(request);
        }
    }
}
