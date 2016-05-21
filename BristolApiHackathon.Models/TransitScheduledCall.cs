namespace BristolApiHackathon.Models
{
    public class TransitScheduledCall
    {
        public string ScheduledArrivalTime { get; set; }
        public string ScheduledDepartureTime { get; set; }
        public int PickUpType { get; set; }
        public int DropOffType { get; set; }
    }
}