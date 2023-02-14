using System.ComponentModel.DataAnnotations.Schema;

namespace GalaxyForge.Models
{
    public class GalacticZone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GalacticZoneId { get; set; }

        public string GalacticZoneAddress { get; set; }
        public string? GalacticZoneName { get; set; }

        public virtual GalacticSector GalacticSectorId { get; set; }
        public virtual ICollection<Region>? Regions { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
    }
}