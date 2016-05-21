using System.Collections.Generic;

namespace BristolApiHackathon.Models
{
    public class ApiResponse
    {
        public bool? Success { get; set; }
        public string LocalizedErrorMessage { get; set; }
        public object Data { get; set; }
    }

    public class ApiResponse<T>
    {
        public bool? Success { get; set; }
        public string LocalizedErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
