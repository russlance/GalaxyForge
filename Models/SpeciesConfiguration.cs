using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class SpeciesConfiguration : EntityTypeConfiguration<Species>
    {
        public SpeciesConfiguration()
        {
            this.Property(s => s.SpeciesName)
                .IsOptional()
                .HasMaxLength(20);

            this.Property(s => s.SpeciesName)
                .IsConcurrencyToken();

            this.Property(s => s.SpeciesDescription)
                .IsOptional()
                .HasMaxLength(500);
        }
    }
}