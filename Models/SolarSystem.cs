using System.ComponentModel.DataAnnotations.Schema;

namespace GalaxyForge.Models
{
    public class SolarSystem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SolarSystemId { get; set; }

        public string SolarSystemAddress { get; set; }
        public string? SolarSystemName { get; set; }
        public int? SolarSystemGalacticPlaneVariance { get; set; }

        public virtual Sector SectorID { get; set; }
        public virtual ICollection<CelestialBody>? CelestialBodies { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
    }
}