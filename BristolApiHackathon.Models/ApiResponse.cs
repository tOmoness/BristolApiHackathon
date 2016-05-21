using System.Collections.Generic;

namespace BristolApiHackathon.Models
{
    public class ApiResponse
    {
        public bool? Success { get; set; }
        public string LocalizedErrorMessage { get; set; }
        public IList<object> Data { get; set; }
    }
}
