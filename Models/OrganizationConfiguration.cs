using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class OrganizationConfiguration : EntityTypeConfiguration<Organization>
    {
        public OrganizationConfiguration()
        {
            this.Property(s => s.OrganizationName)
                .IsOptional()
                .HasMaxLength(20);

            this.Property(s => s.OrganizationName)
                .IsConcurrencyToken();

            this.Property(s => s.OrganizationDescription)
                .IsOptional()
                .HasMaxLength(800);
        }
    }
}