namespace GalaxyForge.Models
{
    public class Species
    {
        public int SpeciesId { get; set; }
        public string? SpeciesName { get; set; }
        public string? SpeciesDescription { get; set; }

        public int? CelestialBodyId { get; set; } // Homeworld
        public int? GovernmentId { get; set; }  // Ruling government
        public int? OrganizationId { get; set; }  // or ruling organization
    }
}