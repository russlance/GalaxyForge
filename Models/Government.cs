namespace GalaxyForge.Models
{
    public class Government
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? StartDate { get; set; }
        public int? EndDate { get; set; }

        public virtual int? CelestialBodyId { get; set; }   // Capital World
        public virtual ICollection<GalacticSector>? GalacticSectors { get; set; }
        public virtual ICollection<GalacticZone>? GalacticZones { get; set; }
        public virtual ICollection<Region>? Regions { get; set; }
        public virtual ICollection<Sector>? Sectors { get; set; }
        public virtual ICollection<SolarSystem>? SolarSystems { get; set; }

        public virtual ICollection<CelestialBody>? CelestialBodies { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
    }
}