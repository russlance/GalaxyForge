using System.Data.Entity.ModelConfiguration;

namespace GalaxyForge.Models
{
    public class EventConfiguration : EntityTypeConfiguration<Event>
    {
        public EventConfiguration()
        {
            this.Property(s => s.Description)
                .IsOptional()
                .HasMaxLength(800);
        }
    }
}