using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class StructureConfiguration : EntityTypeConfiguration<Structure>
    {
        public StructureConfiguration()
        {
            this.Property(s => s.StructureName)
                .IsOptional()
                .HasMaxLength(20);

            this.Property(s => s.StructureName)
                .IsConcurrencyToken();
        }
    }
}