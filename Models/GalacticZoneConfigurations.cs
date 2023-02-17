using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class GalacticZoneConfigurations : EntityTypeConfiguration<GalacticZone>
    {
        public GalacticZoneConfigurations()
        {
            this.Property(s => s.Name)
                .IsOptional()
                .HasMaxLength(20);
        }
    }
}