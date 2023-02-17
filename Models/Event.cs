namespace GalaxyForge.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int? StartDate { get; set; }
        public int? EndDate { get; set; }

        public virtual ICollection<Sector>? Sectors { get; set; }
        public virtual ICollection<CelestialBody>? CelestialBodies { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
    }
}