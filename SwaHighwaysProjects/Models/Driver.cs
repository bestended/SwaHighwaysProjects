namespace SwaHighwaysProjects.Models
{
    public class Driver
    {

        public int DriverId { get; set; }
        public string? IdentificationNum { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime LicenceDate { get; set; }
        public int Age { get; set; }
        public string? Phone { get; set; }
        public string? mail { get; set; }

        public string? type { get; set; }


    }
}
