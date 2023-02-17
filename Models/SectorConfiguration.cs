using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class SectorConfiguration : EntityTypeConfiguration<Sector>
    {
        public SectorConfiguration()
        {
            this.Property(s => s.Name)
                .IsOptional()
                .HasMaxLength(20);
        }
    }
}