﻿using System.Collections.Generic;

namespace BristolApiHackathon.Models
{
    public class DirectionsResponse
    {
        public string ResponseId { get; set; }
        public DirectionsResponseStatus Status { get; set; }
        public IList<Journey> Journeys { get; set; }
        public IList<PlacePoints> PlacePoints { get; set; }
        public string SourceName { get; set; }
        public string AttributionsHtml { get; set; }
        public string WarningsHtml { get; set; }
    }
}
