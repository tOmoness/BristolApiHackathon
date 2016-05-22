using System.Collections.Generic;

namespace BristolApiHackathon.Models
{
    public class Journey
    {
        public string ArrivalTime { get; set; }
        public string DepartureTime { get; set; }
        public string SummaryHtml { get; set; }
        public int? Duration { get; set; }
        public List<TransitJourneyLeg> Legs { get; set; }
        public string OriginPlacePointId { get; set; }
        public string DestinationPlacePointId { get; set; }
    }
}