namespace GalaxyForge.Models
{
    public class Sector
    {
        public int SectorID { get; set; }
        public string? SectorName { get; set; }

        public virtual ICollection<SolarSystem>? SolarSystems { get; set; }
    }
}