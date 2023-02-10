using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class SolarSystemConfiguration : EntityTypeConfiguration<SolarSystem>
    {
        public SolarSystemConfiguration()
        {
            this.Property(s => s.SolarSystemName)
                .IsOptional()
                .HasMaxLength(20);

            this.Property(s => s.SolarSystemName)
                .IsConcurrencyToken();

            this.Property(s => s.SolarSystemAddress)
                .IsOptional()
                .HasMaxLength(12);
        }
    }
}