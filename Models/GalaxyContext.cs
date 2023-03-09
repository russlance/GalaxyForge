using System.Data.Entity;

namespace GalaxyForge.Models
{
    public class GalaxyContext : DbContext
    {
        public GalaxyContext() : base("GalaxyDB")
        {
            /* https://www.entityframeworktutorial.net/code-first/database-initialization-strategy-in-code-first.aspx */

            Database.SetInitializer(new GalaxyDBInitializer());
        }

        /*
                 protected override void OnModelCreating(DbModelBuilder modelBuilder)
                {
                    modelBuilder.Configurations.Add(new GalacticSectorConfigurations());

                                 modelBuilder.Entity<GalacticZone>()
                                    .ToTable("Galactic Zones");

                                modelBuilder.Entity<GalacticZone>()
                                    .MapToStoredProcedures();
                }
         */

        public DbSet<CelestialBody>? CelestialBodies { get; set; }
        public DbSet<City>? Cities { get; set; }

        public DbSet<Equipment>? Equipment { get; set; }
        public DbSet<Event>? Events { get; set; }
        public DbSet<GalacticSector>? GalacticSectors { get; set; }

        public DbSet<GalacticZone>? GalacticZones { get; set; }
        public DbSet<Government>? Governments { get; set; }
        public DbSet<Organization>? Organizations { get; set; }
        public DbSet<Region>? Regions { get; set; }
        public DbSet<Sector>? Sectors { get; set; }
        public DbSet<Ship>? Ships { get; set; }
        public DbSet<SolarSystem>? SolarSystems { get; set; }
        public DbSet<Species>? Species { get; set; }
        public DbSet<Structure>? Structures { get; set; }
    }
}