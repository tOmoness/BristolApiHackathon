namespace BristolApiHackathon.Models
{
    public class StopCall
    {
        public TransitTripInfo TripInfo { get; set; }
        public TransitRouteInfo RouteInfo { get; set; }
        public TransitScheduledCall ScheduledCall { get; set; }
    }
}