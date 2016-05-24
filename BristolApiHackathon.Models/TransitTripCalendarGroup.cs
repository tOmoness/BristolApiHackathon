using System.Collections.Generic;

namespace BristolApiHackathon.Models
{
    public class TransitTripCalendarGroup
    {
        public TransitCalendar Calendar { get; set; }
        public List<TransitTrip> Trips { get; set; }
    }
}
