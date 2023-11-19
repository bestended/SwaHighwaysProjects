namespace SwaHighwaysProjects.Models
{
    public class Motorways
    {
        public int MotorwayId { get; set; }
        public int Distance { get; set; }
        public int NumberOfLanes { get; set; }
        public int NumberOfSigns { get; set; }
        public int NumberOfTollGate { get; set; }

        public string? type { get; set; }


    }
}
