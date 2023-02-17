using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class OrganizationConfiguration : EntityTypeConfiguration<Organization>
    {
        public OrganizationConfiguration()
        {
            this.Property(s => s.Name)
                .IsOptional()
                .HasMaxLength(20);

            this.Property(s => s.Description)
                .IsOptional()
                .HasMaxLength(800);
        }
    }
}