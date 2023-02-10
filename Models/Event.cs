namespace GalaxyForge.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventDescription { get; set; }
        public int? EventDate { get; set; }

        public virtual ICollection<Sector>? Sectors { get; set; }
        public virtual ICollection<CelestialBody>? CelestialBodies { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
    }
}