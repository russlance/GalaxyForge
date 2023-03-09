using System.ComponentModel.DataAnnotations.Schema;

namespace GalaxyForge.Models
{
    public class Equipment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? Condition { get; set; }
        public int? StartDate { get; set; }

        public virtual CelestialBody? CelestialBodyId { get; set; }
        public virtual Government? GovernmentId { get; set; }
        public virtual Organization? OrganizationId { get; set; }
    }
}