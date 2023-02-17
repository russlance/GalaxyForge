using System.ComponentModel.DataAnnotations.Schema;

namespace GalaxyForge.Models
{
    public class GalacticZone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Q { get; set; }
        public int R { get; set; }
        public int S { get; set; }
        public string? Name { get; set; }

        public virtual GalacticSector GalacticSectorId { get; set; }
        public virtual ICollection<Region>? Regions { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
    }
}