namespace GalaxyForge.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public string? CityDescription { get; set; }
        public int? CityFoundingDate { get; set; }

        public virtual CelestialBody? CelestialBodyId { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
        public virtual ICollection<CelestialBody>? CelestialBodies { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
    }
}