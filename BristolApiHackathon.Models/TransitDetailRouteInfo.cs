namespace BristolApiHackathon.Models
{
    public class TransitDetailRouteInfo
    {
        public string RouteDescription { get; set; }
        public string AgencyCode { get; set; }
        public string RouteId { get; set; }
        public string LineName { get; set; }
        public string LineColor { get; set; }
        public string LineTextColor { get; set; }
        public string OperatorName { get; set; }
        public string OperatorId { get; set; }
        public string OperatorRegion { get; set; }
        public int RouteType { get; set; }
        public int CentrePointLat { get; set; }
        public int CentrePointLng { get; set; }
    }
}