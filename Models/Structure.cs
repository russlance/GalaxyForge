using System.ComponentModel.DataAnnotations.Schema;

namespace GalaxyForge.Models
{
    public class Structure
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? StartDate { get; set; }
        public int? EndDate { get; set; }

        public virtual SolarSystem? SolarSystem { get; set; }
        public virtual CelestialBody? CelestialBodyId { get; set; }
        public virtual int? OrganizationId { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
        public virtual ICollection<Equipment>? Equipment { get; set; }
    }
}