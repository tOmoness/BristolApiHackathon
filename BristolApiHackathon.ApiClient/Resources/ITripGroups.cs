using System.Collections.Generic;
using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public interface ITripGroups
    {
        IEnumerable<TransitTripCalendarGroup> GetByCalendar(string routeId, bool includePolyLines,
            bool includeStopCoordinates);
    }
}