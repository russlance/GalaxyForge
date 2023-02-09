using System.Data.Entity;

namespace GalaxyForge.Models
{
    public class GalaxyContext : DbContext
    {
        public GalaxyContext() : base("GalaxyDB")
        {
            Database.SetInitializer<GalaxyContext>(new GalaxyDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GalacticSectorConfigurations());

            modelBuilder.Entity<GalacticZone>()
                .ToTable("Galactic Zones");

            modelBuilder.Entity<GalacticZone>()
                .MapToStoredProcedures();
        }

        public DbSet<GalacticSector> GalacticSectors { get; set; }
    }
}