using System;
using BristolApiHackathon.Models;

namespace BristolApiHackathon.ApiClient.Resources
{
    public interface IStopCalls
    {
        TransitStopScheduledCalls Get(string stopId, DateTime queryTime, int lookAheadMinutes);
    }
}