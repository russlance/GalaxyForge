using System.ComponentModel.DataAnnotations.Schema;

namespace GalaxyForge.Models
{
    public class CelestialBody
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual int? SolarSystemId { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
    }
}