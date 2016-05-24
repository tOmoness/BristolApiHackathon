using System.Collections.Generic;

namespace BristolApiHackathon.Models
{
    public class TransitTrip
    {
        public TransitTripInfo Info { get; set; }
        public TransitCalendar Calendar { get; set; }
        public List<TransitStopScheduledCallSummary> StopCalls { get; set; }
        public string PolyLine { get; set; }
    }
}