using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class SectorConfiguration : EntityTypeConfiguration<Sector>
    {
        public SectorConfiguration()
        {
            this.Property(s => s.SectorName)
                .IsOptional()
                .HasMaxLength(20);

            this.Property(s => s.SectorName)
                .IsConcurrencyToken();
        }
    }
}