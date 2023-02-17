namespace GalaxyForge.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? StartDate { get; set; }
        public int? EndDate { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Species>? Species { get; set; }
        public virtual ICollection<Government>? Governments { get; set; }
        public virtual ICollection<Structure>? Structures { get; set; }
    }
}