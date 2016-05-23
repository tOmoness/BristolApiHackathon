using System.Collections.Generic;

namespace BristolApiHackathon.Models
{
    public class TransitJourneyLeg
    {
        public TransitRouteInfo LinkedTransitRouteInfo { get; set; }
        public TransitTripInfo LinkedTransitTripInfo { get; set; }
        public List<TransitStopScheduledCall> ScheduledStopCalls { get; set; }
        public string Type { get; set; }
        public string SummaryHtml { get; set; }
        public string OriginPlacePointId { get; set; }
        public string DestinationPlacePointId { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureTime { get; set; }
        public int? VehicleType { get; set; }
        public int? Duration { get; set; }
        public int? Distance { get; set; }
        public string Polyline { get; set; }
    }
}