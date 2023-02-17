using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class RegionConfiguration : EntityTypeConfiguration<Region>
    {
        public RegionConfiguration()
        {
            this.Property(s => s.Name)
                .IsOptional()
                .HasMaxLength(20);
        }
    }
}