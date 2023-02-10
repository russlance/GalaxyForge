using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class GalacticSectorConfigurations : EntityTypeConfiguration<GalacticSector>
    {
        public GalacticSectorConfigurations()
        {
            this.Property(s => s.GalacticSectorName)
                .IsOptional()
                .HasMaxLength(20);
        }
    }
}