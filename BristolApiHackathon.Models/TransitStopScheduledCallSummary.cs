namespace BristolApiHackathon.Models
{
    public class TransitStopScheduledCallSummary
    {
        public string TransitStopPrimaryCode { get; set; }
        public string TransitStopName { get; set; }
        public string TransitStopLocalityName { get; set; }
        public TransitScheduledCall ScheduledCall { get; set; }
        public double TransitStopLatitude { get; set; }
        public double TransitStopLongitude { get; set; }
    }
}