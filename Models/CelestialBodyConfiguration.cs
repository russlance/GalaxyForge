using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class CelestialBodyConfiguration : EntityTypeConfiguration<CelestialBody>
    {
        public CelestialBodyConfiguration()
        {
            this.Property(s => s.CelestialBodyName)
                .IsOptional()
                .HasMaxLength(20);

            this.Property(s => s.CelestialBodyName)
                .IsConcurrencyToken();

            this.Property(s => s.CelestialBodyAddress)
                .IsOptional()
                .HasMaxLength(12);

            this.Property(s => s.CelestialBodyAddress)
                .IsConcurrencyToken();
        }
    }
}