using System.ComponentModel.DataAnnotations.Schema;

namespace GalaxyForge.Models
{
    public class Sector
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SectorID { get; set; }

        public string SectorAddress { get; set; }
        public string? SectorName { get; set; }

        public virtual Region RegionId { get; set; }
        public virtual ICollection<SolarSystem>? SolarSystems { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Organization>? Organizations { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
    }
}