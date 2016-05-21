namespace BristolApiHackathon.Models
{
    public class DirectionsRequest
    {
        public string AgencyCode { get; set; }
        public Origin Origin { get; set; }
        public Destination Destination { get; set; }
        public int TravelContext { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public int JourneyTimeMode { get; set; }
        public int MaximumJourneys { get; set; }
        public Options Options { get; set; }
        public CustomOptions CustomOptions { get; set; }
        public bool EnableRouteGeometry { get; set; }
        public bool EnableRealtimeResults { get; set; }
        public bool EnableFareResults { get; set; }
    }

}
