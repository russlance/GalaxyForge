using System.ComponentModel.DataAnnotations.Schema;

namespace GalaxyForge.Models
{
    public class Species
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? StartDate { get; set; }
        public int? EndDate { get; set; }

        public virtual int? CelestialBodyId { get; set; } // Homeworld
        public virtual int? GovernmentId { get; set; }  // Ruling government
        public virtual int? OrganizationId { get; set; }  // or ruling organization
    }
}