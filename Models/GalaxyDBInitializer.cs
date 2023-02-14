﻿using System.Data.Entity;

namespace GalaxyForge.Models
{
    /* https://www.entityframeworktutorial.net/code-first/database-initialization-strategy-in-code-first.aspx */

    public class GalaxyDBInitializer : DropCreateDatabaseAlways<GalaxyContext>
    {
        protected override void Seed(GalaxyContext context)
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
        }
    }
}