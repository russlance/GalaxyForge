namespace GalaxyForge.Models
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionAddress { get; set; }
        public string? RegionName { get; set; }

        public virtual GalacticZone GalacticZoneId { get; set; }
        public virtual ICollection<Sector>? Sectors { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
    }
}