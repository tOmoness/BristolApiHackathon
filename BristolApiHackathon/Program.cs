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

            var importSources = client.Send(BristolApiRequest.CreateImportSourcesRequest());

            var agenciesRequest = BristolApiRequest.CreateAgenciesRequest();

            var agencies = client.Send(agenciesRequest);

            var directionsRequest = BristolApiRequest.CreateDirectionsRequest(new DirectionsRequest
            {
                //DepartureTime = DateTime.UtcNow.ToLongDateString(),
                DepartureTime = "2016-05-21T14:40:00.000Z",
                Origin = new Origin { Lat = 51.430098, Lng = -2.611623 },
                Destination = new Destination { Lat = 51.454730, Lng = -2.527380 },
                AgencyId = "UK_TNDS_NOC_FSAV"
            });

            var response = client.Send(directionsRequest);
        }
    }
}
