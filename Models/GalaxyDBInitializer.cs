using System.Data.Entity;

namespace GalaxyForge.Models
{
    /* https://www.entityframeworktutorial.net/code-first/database-initialization-strategy-in-code-first.aspx */

    /*
     When changing schema:
        Nothing needs to be done since am using "DropCreateDatabaseAlways"
        After development will use:

             public class GalaxyDBInitializer : CreateDatabaseIfNotExists<GalaxyContext>;

    */

    public class GalaxyDBInitializer : DropCreateDatabaseAlways<GalaxyContext>
    {
        protected override void Seed(GalaxyContext context)
        {
            IList<GalacticSector> galacticSectors = new List<GalacticSector>();

            galacticSectors.Add(new GalacticSector()
            {
                Q = 0,
                R = 0,
                S = 0,
                Name = "Sector 1"
            });
            galacticSectors.Add(new GalacticSector()
            {
                Q = 0,
                R = 0,
                S = 0,
                Name = "Sector 2"
            });
            galacticSectors.Add(new GalacticSector()
            {
                Q = 0,
                R = 0,
                S = 0,
                Name = "Sector 3"
            });
            galacticSectors.Add(new GalacticSector()
            {
                Q = 0,
                R = 0,
                S = 0,
                Name = "Sector 4"
            });
            galacticSectors.Add(new GalacticSector()
            {
                Q = 0,
                R = 0,
                S = 0,
                Name = "Sector 5"
            });
            galacticSectors.Add(new GalacticSector()
            {
                Q = 0,
                R = 0,
                S = 0,
                Name = "Sector 6"
            });
            galacticSectors.Add(new GalacticSector()
            {
                Q = 0,
                R = 0,
                S = 0,
                Name = "Sector 7"
            });

            context.GalacticSectors.AddRange(galacticSectors);
            //context.SaveChanges();

            base.Seed(context);
        }
    }
}