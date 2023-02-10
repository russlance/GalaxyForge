namespace GalaxyForge.Models
{
    public class CelestialBody
    {
        public int CelestialBodyId { get; set; }
        public string? CelestialBodyName { get; set; }
        public string? CelestialBodyDescription { get; set; }

        public int SolarSystemId { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
        public virtual ICollection<Structure>? Structure { get; set; }
        public virtual ICollection<Government>? GovernmentId { get; set; }
        public virtual ICollection<Organization>? OrganizationId { get; set; }
    }
}