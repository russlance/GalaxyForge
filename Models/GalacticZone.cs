namespace GalaxyForge.Models
{
    public class GalacticZone
    {
        public int GalacticZoneId { get; set; }
        public string? GalacticZoneName { get; set; }

        public virtual ICollection<Region>? Regions { get; set; }
    }
}