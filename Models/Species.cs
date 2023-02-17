namespace GalaxyForge.Models
{
    public class Species
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? StartDate { get; set; }
        public int? EndDate { get; set; }

        public int? CelestialBodyId { get; set; } // Homeworld
        public int? GovernmentId { get; set; }  // Ruling government
        public int? OrganizationId { get; set; }  // or ruling organization
    }
}