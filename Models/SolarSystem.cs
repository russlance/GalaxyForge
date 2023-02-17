using System.ComponentModel.DataAnnotations.Schema;

namespace GalaxyForge.Models
{
    public class SolarSystem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Q { get; set; }
        public int R { get; set; }
        public int S { get; set; }
        public string? Name { get; set; }
        public int? PlaneVariance { get; set; }

        public virtual Sector SectorID { get; set; }
        public virtual ICollection<CelestialBody>? CelestialBodies { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
    }
}