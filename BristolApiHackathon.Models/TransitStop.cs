namespace BristolApiHackathon.Models
{
    public class TransitStop
    {
        public string AdditionalCode { get; set; }
        public string SmsCode { get; set; }
        public int Bearing { get; set; }
        public string DirectionName { get; set; }
        public string StopIndicator { get; set; }
        public bool IsClosed { get; set; }
        public int StopMode { get; set; }
        public string ImportSource { get; set; }
        public string PrimaryCode { get; set; }
        public int PlacePointType { get; set; }
        public string LocalityName { get; set; }
        public string Country { get; set; }
        public bool HasResourceStatus { get; set; }
        public string SubClassType { get; set; }
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string ParentPrimaryCode { get; set; }
    }
}