namespace BristolApiHackathon.Models
{
    public class Origin
    {
        public string ImportSource { get; set; }
        public string PrimaryCode { get; set; }
        public int PlacePointType { get; set; }
        public string LocalityName { get; set; }
        public string Country { get; set; }
        public bool HasResourceStatus { get; set; }
        public string SubClassType { get; set; }
        public string Name { get; set; }
        public int Lat { get; set; }
        public int Lng { get; set; }
    }
}