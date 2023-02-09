namespace GalaxyForge.Models
{
    public class CelestialBody
    {
        public int CelestialBodyId { get; set; }
        public string? CelestialBodyAddress { get; set; }
        public string? CelestialBodyName { get; set; }
        public string? CelestialBodyDescription { get; set; }

        public virtual ICollection<Species>? Species { get; set; }
    }
}