namespace SwaHighwaysProjects.Models
{
    public class Vehicle
    {

        public int CarId { get; set; }
        public string? Plate { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public int DriverId { get; set; }
        public int BridgeId { get; set; }

        public string? type { get; set; }

    }
}
