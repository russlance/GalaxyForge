namespace GalaxyForge.Models
{
    public class Structure
    {
        public int StuctureId { get; set; }
        public string? StructureName { get; set; }
        public string? StructureDescription { get; set; }

        public int? OrganizationId { get; set; }
        public int? GovernmentId { get; set; }
        public virtual ICollection<Species>? Species { get; set; }
    }
}