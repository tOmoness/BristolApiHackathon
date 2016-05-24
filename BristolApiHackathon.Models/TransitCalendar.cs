using System.Collections.Generic;

namespace BristolApiHackathon.Models
{
    public class TransitCalendar
    {
        public string Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool RunsSunday { get; set; }
        public bool RunsMonday { get; set; }
        public bool RunsTuesday { get; set; }
        public bool RunsWednesday { get; set; }
        public bool RunsThursday { get; set; }
        public bool RunsFriday { get; set; }
        public bool RunsSaturday { get; set; }
        public List<string> AdditionalRunningDates { get; set; }
        public List<string> ExcludedRunningDates { get; set; }
    }
}