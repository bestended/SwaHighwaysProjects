namespace SwaHighwaysProjects.Models
{
    public class Bridge
    {

        public int BridgeId { get; set; }

        public string? BridgeName { get; set; }

        public DateTime DatetimeOfEntry { get; set; }
        public DateTime ReleaseDatetime { get; set; }
        public decimal Toll { get; set; }
        public string? EntranceLocation { get; set; }
        public string? ExitLocation { get; set; }
        public int MotorwayId { get; set; }

        public string? type { get; set; }
    }
}
