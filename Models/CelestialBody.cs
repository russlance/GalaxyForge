namespace GalaxyForge.Models
{
    public class CelestialBody
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int SolarSystemId { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
        public virtual ICollection<Structure>? Structure { get; set; }
        public virtual ICollection<Government>? GovernmentId { get; set; }
        public virtual ICollection<Organization>? OrganizationId { get; set; }
    }
}