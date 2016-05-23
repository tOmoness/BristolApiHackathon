using System;
using System.Collections.Generic;
using System.Configuration;
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

            //var importSources = client.Send<List<ImportSource>>(BristolApiRequest.CreateImportSourcesRequest());

            var agenciesRequest = BristolApiRequest.CreateAgenciesRequest(importSource: "TNDS");

            //var agencies = client.Send<List<TransitAgency>>(agenciesRequest);

            var directionsRequest = BristolApiRequest.CreateDirectionsRequest(new DirectionsRequest
            {

                DepartureTime = "2016-05-21T14:40:00.000Z",
                Origin = new Origin { Lat = 51.421141, Lng = -2.628234 },
                Destination = new Destination { Lat = 51.454730, Lng = -2.527380 },
                AgencyId = "UK_TNDS_NOC_FSAV"
            });

            var response = client.Send<DirectionsResponse>(directionsRequest);

            ProcessResponse(response.Data);

            Console.ReadKey(true);
        }

        private static void ProcessResponse(DirectionsResponse response)
        {
            foreach (var journey in response.Journeys)
            {
                var leg = journey.Legs.Skip(1).Take(1).First();

                Console.WriteLine($"Bus No: {leg.LinkedTransitRouteInfo.LineName} (" +
                                  $"{leg.LinkedTransitTripInfo.Headsign}");
                Console.WriteLine(new string('-', 20));
                leg.ScheduledStopCalls.ForEach(stop => Console.WriteLine(stop.Stop.Name));
                Console.WriteLine(new string('-', 20));

                TransitStopScheduledCall firstStop = null;
                TransitStopScheduledCall lastStop = null;
                var longestBusDistance = 0.0;

                for (int i = 0; i < leg.ScheduledStopCalls.Count; i++)
                {
                    if (i + 3 >= leg.ScheduledStopCalls.Count - 3)
                        break;

                    var lengthTest = CalculateDistanceAlongStops(leg.ScheduledStopCalls.GetRange(i, 3));

                    if (lengthTest > longestBusDistance)
                    {
                        longestBusDistance = lengthTest;
                        firstStop = leg.ScheduledStopCalls[i];
                        lastStop = leg.ScheduledStopCalls[i + 3];
                    }
                }

                if (firstStop == null || lastStop == null) throw new Exception("A three stop hop could not be found.");

                var totalDistance = CalculateDistanceAlongStops(leg.ScheduledStopCalls);

                var firstWalkDistance = CalculateDistanceAlongStops(leg.ScheduledStopCalls.GetRange(0, leg.ScheduledStopCalls.IndexOf(firstStop) + 1));

                var lastWalkDistance =
                    CalculateDistanceAlongStops(leg.ScheduledStopCalls.GetRange(
                        leg.ScheduledStopCalls.IndexOf(lastStop),
                        leg.ScheduledStopCalls.Count - leg.ScheduledStopCalls.IndexOf(lastStop)));

                Console.WriteLine($"Best value for three stop hop: {firstStop.Stop.Name} to {lastStop.Stop.Name}.");
                Console.WriteLine($"Total bus distance: {longestBusDistance:N2} miles");
                Console.WriteLine($"Total journey distance: {totalDistance:N2} miles");
                Console.WriteLine($"First walk distance: {firstWalkDistance:N2} miles");
                Console.WriteLine($"Last walk distance: {lastWalkDistance:N2} miles");
                break;
            }
        }

        private static double CalculateDistanceAlongStops(IList<TransitStopScheduledCall> stops)
        {
            var distance = 0.0;
            for (int i = 0; i < stops.Count - 1; i++)
            {
                distance += GeoCodeCalc.CalcDistance(stops[i].Stop.Lat, stops[i].Stop.Lng, stops[i + 1].Stop.Lat,
                        stops[i + 1].Stop.Lng);
            }
            return distance;
        }
    }
}
