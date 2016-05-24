﻿using System.Collections.Generic;

namespace BristolApiHackathon.ApiClient.Resources
{
    public interface IPlaces
    {
        IEnumerable<PlacePoints> Get(string name, string placePointTypes, double lat, double lng,
            string countryCode, int maxResultsPerType);
    }
}