namespace GalaxyForge.Models
{
    public class SolarSystem
    {
        public int SolarSystemId { get; set; }
        public string? SolarSystemAddress { get; set; }
        public string? SolarSystemName { get; set; }

        public virtual ICollection<CelestialBody>? CelestialBodies { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
    }
}