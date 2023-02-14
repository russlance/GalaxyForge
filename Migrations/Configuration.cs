namespace GalaxyForge.Migrations
{
    using GalaxyForge.Models;
    using System.Data.Entity.Migrations;

    /* Each time the DB Tables are adjusted, run:
        - add-migration <name you use>
        - update-database

        For more info, see:
            https://www.youtube.com/watch?v=yT04aOPRs-g
    */

    internal sealed class Configuration : DbMigrationsConfiguration<GalaxyForge.Models.GalaxyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GalaxyForge.Models.GalaxyContext context)
        {
            IList<GalacticSector> galacticSectors = new List<GalacticSector>();

            galacticSectors.Add(new GalacticSector()
            {
                GalacticSectorName = "Sector 1"
            });
            galacticSectors.Add(new GalacticSector()
            {
                GalacticSectorName = "Sector 2"
            });
            galacticSectors.Add(new GalacticSector()
            {
                GalacticSectorName = "Sector 3"
            });
            galacticSectors.Add(new GalacticSector()
            {
                GalacticSectorName = "Sector 4"
            });
            galacticSectors.Add(new GalacticSector()
            {
                GalacticSectorName = "Sector 5"
            });
            galacticSectors.Add(new GalacticSector()
            {
                GalacticSectorName = "Sector 6"
            });
            galacticSectors.Add(new GalacticSector()
            {
                GalacticSectorName = "Sector 7"
            });

            context.GalacticSectors.AddRange(galacticSectors);

            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}