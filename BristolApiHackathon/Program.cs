﻿using System;
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
                //Origin = new Origin { Lat = 51.430098, Lng = -2.611623 },
                Origin = new Origin { Lat = 51.421141, Lng = -2.628234 },
                Destination = new Destination { Lat = 51.454730, Lng = -2.527380 },
                AgencyId = "UK_TNDS_NOC_FSAV"
            });

            var response = client.Send(directionsRequest);

            ProcessResponse(response);

            Console.ReadKey(true);
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

                Console.WriteLine(new string('-', 20));
                stops.ForEach(x => Console.WriteLine(x.Id));
                Console.WriteLine(new string('-', 20));


                var firstStop = new Stop();
                var lastStop = new Stop();
                var longestDistance = 0.0;
                var totalDistance = 0.0;

                for (int i = 0; i < stops.Count-1; i++)
                {
                    totalDistance += GeoCodeCalc.CalcDistance(stops[i].Lat, stops[i].Long, stops[i + 1].Lat,
                        stops[i + 1].Long);
                }

                for (int i = 0; i < stops.Count; i++)
                {
                    if (i + 3 >= stops.Count - 3)
                        break;

                    var lengthTest = GeoCodeCalc.CalcDistance(stops[i].Lat, stops[i].Long, stops[i + 3].Lat,
                        stops[i + 3].Long);

                    if (lengthTest > longestDistance)
                    {
                        longestDistance = lengthTest;
                        firstStop = stops[i];
                        lastStop = stops[i + 3];
                    }
                }

                Console.WriteLine($"Best value for three stop hop: {firstStop.Id} to {lastStop.Id}. ({longestDistance:N2} miles)");
                Console.WriteLine($"Total journey distance: {totalDistance:N2} miles");
                break;
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
