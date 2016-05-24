using System.Collections.Generic;

namespace BristolApiHackathon.Models
{
    public class TransitStopScheduledCalls
    {
        public string StopId { get; set; }
        public string QueryStartTime { get; set; }
        public string QueryEndTime { get; set; }
        public List<StopCall> ScheduledCalls { get; set; }
    }
}
