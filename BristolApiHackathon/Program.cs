using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using BristolApiHackathon.ApiClient;
using BristolApiHackathon.Models;
using RestSharp;

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

            ProcessResponse(response);
        }

        private static void ProcessResponse(ApiResponse response)
        {
            var journeys = (response.Data as Dictionary<string, object>)["journeys"] as JsonArray;

            foreach (Dictionary<string, object> journey in journeys)
            {
                var legs = journey["legs"] as JsonArray;

                var leg = legs[1] as Dictionary<string, object>;

                var untypedStops = (leg["scheduledStopCalls"] as JsonArray);
                
                List<Stop> stops = new List<Stop>();
                foreach (Dictionary<string, object> stop in untypedStops)
                {
                    var stopAsDick = stop["stop"] as Dictionary<string, object>;
                    stops.Add(new Stop
                    {
                        Id = stopAsDick["name"].ToString(),
                        Lat = double.Parse(stopAsDick["lat"].ToString()),
                        Long = double.Parse(stopAsDick["lng"].ToString())
                    });
                }


            }
        }

        private class Stop
        {
            public string Id { get; set; }
            public double Lat { get; set; }
            public double Long { get; set; }
        }
    }
}
