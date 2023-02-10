namespace GalaxyForge.Models
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public string? OrganizationName { get; set; }
        public int? FormationDate { get; set; }
        public string? OrganizationDescription { get; set; }

        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
    }
}