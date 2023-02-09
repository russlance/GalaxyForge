using System.Data.Entity;

namespace GalaxyForge.Models
{
    public class GalaxyDBInitializer : DropCreateDatabaseAlways<GalaxyContext>
    {
        protected override void Seed(GalaxyContext context)
        {
            IList<GalacticSector> galacticSectors = new List<GalacticSector>
            {
                new GalacticSector() { GalacticSectorName = "Galactic Core" },
                new GalacticSector() { GalacticSectorName = "Sector 1" },
                new GalacticSector() { GalacticSectorName = "Sector 2" },
                new GalacticSector() { GalacticSectorName = "Sector 3" },
                new GalacticSector() { GalacticSectorName = "Sector 4" },
                new GalacticSector() { GalacticSectorName = "Sector 5" },
                new GalacticSector() { GalacticSectorName = "Sector 6" }
            };

            context.GalacticSectors.AddRange(galacticSectors);

            base.Seed(context);
        }
    }
}