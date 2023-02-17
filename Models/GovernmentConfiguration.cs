using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class GovernmentConfiguration : EntityTypeConfiguration<Government>
    {
        public GovernmentConfiguration()
        {
            this.Property(s => s.Name)
                    .IsOptional()
                    .HasMaxLength(20);
        }
    }
}