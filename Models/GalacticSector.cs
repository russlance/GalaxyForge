namespace GalaxyForge.Models
{
    public class GalacticSector
    {
        public int GalacticSectorId { get; set; }
        public string? GalacticSectorName { get; set; }

        public virtual ICollection<GalacticZone>? GalacticZones { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
    }
}