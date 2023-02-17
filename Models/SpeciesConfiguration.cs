using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class SpeciesConfiguration : EntityTypeConfiguration<Species>
    {
        public SpeciesConfiguration()
        {
            this.Property(s => s.Name)
                .IsOptional()
                .HasMaxLength(20);

            this.Property(s => s.Name)
                .IsConcurrencyToken();

            this.Property(s => s.Description)
                .IsOptional()
                .HasMaxLength(500);
        }
    }
}