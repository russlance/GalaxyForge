using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class ShipConfiguration : EntityTypeConfiguration<Ship>
    {
        public ShipConfiguration()
        {
            this.Property(s => s.Name)
                .IsOptional()
                .HasMaxLength(20);
        }
    }
}