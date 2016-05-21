using System.Net;

namespace BristolApiHackathon.Models
{
    public class DirectionsResponseStatus
    {
        public int? StatusCode { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}