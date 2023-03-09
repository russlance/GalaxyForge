using System.ComponentModel.DataAnnotations.Schema;

namespace GalaxyForge.Models
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Condition { get; set; }
        public int? StartDate { get; set; }

        public virtual CelestialBody? CelestialBodyId { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
    }
}