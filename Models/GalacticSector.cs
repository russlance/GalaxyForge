namespace GalaxyForge.Models
{
    public class GalacticSector
    {
        public int GalacticSectorId { get; set; }
        public string? GalacticSectorName { get; set; }

        public virtual ICollection<GalacticZone>? GalacticZones { get; set; }
    }
}