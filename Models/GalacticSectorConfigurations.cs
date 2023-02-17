using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class GalacticSectorConfigurations : EntityTypeConfiguration<GalacticSector>
    {
        public GalacticSectorConfigurations()
        {
            this.Property(s => s.Name)
                .IsOptional()
                .HasMaxLength(20);
        }
    }
}