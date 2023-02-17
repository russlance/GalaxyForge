using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class SolarSystemConfiguration : EntityTypeConfiguration<SolarSystem>
    {
        public SolarSystemConfiguration()
        {
            this.Property(s => s.Name)
                .IsOptional()
                .HasMaxLength(20);
        }
    }
}