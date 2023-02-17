namespace GalaxyForge.Models
{
    public class Ship
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? StartDate { get; set; }
        public int? EndDate { get; set; }

        public Organization? Organization { get; set; }
        public Government? Government { get; set; }
    }
}