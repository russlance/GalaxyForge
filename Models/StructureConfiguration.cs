using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class StructureConfiguration : EntityTypeConfiguration<Structure>
    {
        public StructureConfiguration()
        {
            this.Property(s => s.Name)
                .IsOptional()
                .HasMaxLength(20);
        }
    }
}