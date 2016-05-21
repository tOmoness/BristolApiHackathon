using System;
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

            var client = new BristolApi(apiKey);

            var request = BristolApiRequest.CreateDirectionsRequest(new DirectionsRequest
            {
                DepartureTime = DateTime.UtcNow.ToLongDateString(),
                Origin = new Origin {Lat = 51.454730, Lng = -2.527380},
                Destination = new Destination {Lat = 51.451357, Lng = -2.597563}
            });

            var response = client.Send(request);
        }
    }
}
