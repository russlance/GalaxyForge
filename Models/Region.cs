namespace GalaxyForge.Models
{
    public class Region
    {
        public int RegionId { get; set; }
        public string? RegionName { get; set; }

        public virtual ICollection<Region>? Regions { get; set; }
    }
}