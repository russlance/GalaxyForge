using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class GalacticZoneConfigurations : EntityTypeConfiguration<GalacticZone>
    {
        public GalacticZoneConfigurations()
        {
            this.Property(s => s.GalacticZoneName)
                .IsOptional()
                .HasMaxLength(20);
        }
    }
}