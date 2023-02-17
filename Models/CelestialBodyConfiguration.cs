using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class CelestialBodyConfiguration : EntityTypeConfiguration<CelestialBody>
    {
        public CelestialBodyConfiguration()
        {
            this.Property(s => s.Name)
                .IsOptional()
                .HasMaxLength(20);

            this.Property(s => s.SolarSystemId)
                .IsRequired();
        }
    }
}