using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class RegionConfiguration : EntityTypeConfiguration<Region>
    {
        public RegionConfiguration()
        {
            this.Property(s => s.RegionName)
                .IsOptional()
                .HasMaxLength(20);

            this.Property(s => s.RegionName)
                .IsConcurrencyToken();
        }
    }
}