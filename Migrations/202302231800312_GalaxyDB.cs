namespace GalaxyForge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GalaxyDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Condition = c.String(),
                        StartDate = c.Int(),
                        CelestialBodyId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBodyId_Id)
                .Index(t => t.CelestialBodyId_Id);
            
            CreateTable(
                "dbo.CelestialBodies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        SolarSystemId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystemId)
                .Index(t => t.SolarSystemId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StartDate = c.Int(),
                        EndDate = c.Int(),
                        GalacticSector_Id = c.Int(),
                        GalacticZone_Id = c.Int(),
                        SolarSystem_Id = c.Int(),
                        Region_Id = c.Int(),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSector_Id)
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZone_Id)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_Id)
                .ForeignKey("dbo.Regions", t => t.Region_Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.GalacticSector_Id)
                .Index(t => t.GalacticZone_Id)
                .Index(t => t.SolarSystem_Id)
                .Index(t => t.Region_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Governments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.Int(),
                        EndDate = c.Int(),
                        CelestialBodyId = c.Int(),
                        Organization_Id = c.Int(),
                        Event_Id = c.Int(),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .ForeignKey("dbo.Events", t => t.Event_Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.Organization_Id)
                .Index(t => t.Event_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.GalacticSectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Q = c.Int(nullable: false),
                        R = c.Int(nullable: false),
                        S = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GalacticZones",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Q = c.Int(nullable: false),
                        R = c.Int(nullable: false),
                        S = c.Int(nullable: false),
                        Name = c.String(),
                        GalacticSectorId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSectorId_Id)
                .Index(t => t.GalacticSectorId_Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.Int(),
                        EndDate = c.Int(),
                        Description = c.String(),
                        SolarSystem_Id = c.Int(),
                        Sector_Id = c.Int(),
                        Region_Id = c.Int(),
                        GalacticZone_Id = c.Int(),
                        GalacticSector_Id = c.Int(),
                        Event_Id = c.Int(),
                        CelestialBody_Id = c.Int(),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_Id)
                .ForeignKey("dbo.Sectors", t => t.Sector_Id)
                .ForeignKey("dbo.Regions", t => t.Region_Id)
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZone_Id)
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSector_Id)
                .ForeignKey("dbo.Events", t => t.Event_Id)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBody_Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.SolarSystem_Id)
                .Index(t => t.Sector_Id)
                .Index(t => t.Region_Id)
                .Index(t => t.GalacticZone_Id)
                .Index(t => t.GalacticSector_Id)
                .Index(t => t.Event_Id)
                .Index(t => t.CelestialBody_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Species",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.Int(),
                        EndDate = c.Int(),
                        CelestialBodyId = c.Int(),
                        GovernmentId = c.Int(),
                        OrganizationId = c.Int(),
                        Region_Id = c.Int(),
                        Sector_Id = c.Int(),
                        SolarSystem_Id = c.Int(),
                        Structure_Id = c.Int(),
                        GalacticZone_Id = c.Int(),
                        GalacticSector_Id = c.Int(),
                        Event_Id = c.Int(),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId)
                .ForeignKey("dbo.Regions", t => t.Region_Id)
                .ForeignKey("dbo.Sectors", t => t.Sector_Id)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_Id)
                .ForeignKey("dbo.Structures", t => t.Structure_Id)
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZone_Id)
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSector_Id)
                .ForeignKey("dbo.Events", t => t.Event_Id)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBodyId)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.CelestialBodyId)
                .Index(t => t.OrganizationId)
                .Index(t => t.Region_Id)
                .Index(t => t.Sector_Id)
                .Index(t => t.SolarSystem_Id)
                .Index(t => t.Structure_Id)
                .Index(t => t.GalacticZone_Id)
                .Index(t => t.GalacticSector_Id)
                .Index(t => t.Event_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Structures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.Int(),
                        EndDate = c.Int(),
                        OrganizationId = c.Int(),
                        CelestialBodyId_Id = c.Int(),
                        Region_Id = c.Int(),
                        Sector_Id = c.Int(),
                        SolarSystem_Id = c.Int(),
                        GalacticZone_Id = c.Int(),
                        GalacticSector_Id = c.Int(),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBodyId_Id)
                .ForeignKey("dbo.Regions", t => t.Region_Id)
                .ForeignKey("dbo.Sectors", t => t.Sector_Id)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_Id)
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZone_Id)
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSector_Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.CelestialBodyId_Id)
                .Index(t => t.Region_Id)
                .Index(t => t.Sector_Id)
                .Index(t => t.SolarSystem_Id)
                .Index(t => t.GalacticZone_Id)
                .Index(t => t.GalacticSector_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Description = c.String(),
                        Condition = c.String(),
                        StartDate = c.Int(),
                        CelestialBodyId_Id = c.Int(),
                        GovernmentId_Id = c.Int(),
                        OrganizationId_Id = c.Int(),
                        Structure_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBodyId_Id)
                .ForeignKey("dbo.Governments", t => t.GovernmentId_Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId_Id)
                .ForeignKey("dbo.Structures", t => t.Structure_Id)
                .Index(t => t.CelestialBodyId_Id)
                .Index(t => t.GovernmentId_Id)
                .Index(t => t.OrganizationId_Id)
                .Index(t => t.Structure_Id);
            
            CreateTable(
                "dbo.SolarSystems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Q = c.Int(nullable: false),
                        R = c.Int(nullable: false),
                        S = c.Int(nullable: false),
                        Name = c.String(),
                        PlaneVariance = c.Int(),
                        SectorID_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sectors", t => t.SectorID_Id)
                .Index(t => t.SectorID_Id);
            
            CreateTable(
                "dbo.Sectors",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Q = c.Int(nullable: false),
                        R = c.Int(nullable: false),
                        S = c.Int(nullable: false),
                        Name = c.String(),
                        RegionId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId_Id)
                .Index(t => t.RegionId_Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Q = c.Int(nullable: false),
                        R = c.Int(nullable: false),
                        S = c.Int(nullable: false),
                        Name = c.String(),
                        GalacticZoneId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZoneId_Id)
                .Index(t => t.GalacticZoneId_Id);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.Int(),
                        EndDate = c.Int(),
                        CelestialBodyId_Id = c.Int(),
                        Government_Id = c.Int(),
                        Organization_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBodyId_Id)
                .ForeignKey("dbo.Governments", t => t.Government_Id)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .Index(t => t.CelestialBodyId_Id)
                .Index(t => t.Government_Id)
                .Index(t => t.Organization_Id);
            
            CreateTable(
                "dbo.EventCelestialBodies",
                c => new
                    {
                        Event_Id = c.Int(nullable: false),
                        CelestialBody_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Event_Id, t.CelestialBody_Id })
                .ForeignKey("dbo.Events", t => t.Event_Id, cascadeDelete: true)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBody_Id, cascadeDelete: true)
                .Index(t => t.Event_Id)
                .Index(t => t.CelestialBody_Id);
            
            CreateTable(
                "dbo.GovernmentCelestialBodies",
                c => new
                    {
                        Government_Id = c.Int(nullable: false),
                        CelestialBody_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Government_Id, t.CelestialBody_Id })
                .ForeignKey("dbo.Governments", t => t.Government_Id, cascadeDelete: true)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBody_Id, cascadeDelete: true)
                .Index(t => t.Government_Id)
                .Index(t => t.CelestialBody_Id);
            
            CreateTable(
                "dbo.GalacticZoneGovernments",
                c => new
                    {
                        GalacticZone_Id = c.Int(nullable: false),
                        Government_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GalacticZone_Id, t.Government_Id })
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZone_Id, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_Id, cascadeDelete: true)
                .Index(t => t.GalacticZone_Id)
                .Index(t => t.Government_Id);
            
            CreateTable(
                "dbo.StructureEvents",
                c => new
                    {
                        Structure_Id = c.Int(nullable: false),
                        Event_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Structure_Id, t.Event_Id })
                .ForeignKey("dbo.Structures", t => t.Structure_Id, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_Id, cascadeDelete: true)
                .Index(t => t.Structure_Id)
                .Index(t => t.Event_Id);
            
            CreateTable(
                "dbo.StructureGovernments",
                c => new
                    {
                        Structure_Id = c.Int(nullable: false),
                        Government_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Structure_Id, t.Government_Id })
                .ForeignKey("dbo.Structures", t => t.Structure_Id, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_Id, cascadeDelete: true)
                .Index(t => t.Structure_Id)
                .Index(t => t.Government_Id);
            
            CreateTable(
                "dbo.StructureOrganizations",
                c => new
                    {
                        Structure_Id = c.Int(nullable: false),
                        Organization_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Structure_Id, t.Organization_Id })
                .ForeignKey("dbo.Structures", t => t.Structure_Id, cascadeDelete: true)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id, cascadeDelete: true)
                .Index(t => t.Structure_Id)
                .Index(t => t.Organization_Id);
            
            CreateTable(
                "dbo.SolarSystemGovernments",
                c => new
                    {
                        SolarSystem_Id = c.Int(nullable: false),
                        Government_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SolarSystem_Id, t.Government_Id })
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_Id, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_Id, cascadeDelete: true)
                .Index(t => t.SolarSystem_Id)
                .Index(t => t.Government_Id);
            
            CreateTable(
                "dbo.SectorEvents",
                c => new
                    {
                        Sector_Id = c.Int(nullable: false),
                        Event_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sector_Id, t.Event_Id })
                .ForeignKey("dbo.Sectors", t => t.Sector_Id, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_Id, cascadeDelete: true)
                .Index(t => t.Sector_Id)
                .Index(t => t.Event_Id);
            
            CreateTable(
                "dbo.SectorGovernments",
                c => new
                    {
                        Sector_Id = c.Int(nullable: false),
                        Government_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sector_Id, t.Government_Id })
                .ForeignKey("dbo.Sectors", t => t.Sector_Id, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_Id, cascadeDelete: true)
                .Index(t => t.Sector_Id)
                .Index(t => t.Government_Id);
            
            CreateTable(
                "dbo.RegionGovernments",
                c => new
                    {
                        Region_Id = c.Int(nullable: false),
                        Government_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Region_Id, t.Government_Id })
                .ForeignKey("dbo.Regions", t => t.Region_Id, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_Id, cascadeDelete: true)
                .Index(t => t.Region_Id)
                .Index(t => t.Government_Id);
            
            CreateTable(
                "dbo.GalacticSectorGovernments",
                c => new
                    {
                        GalacticSector_Id = c.Int(nullable: false),
                        Government_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GalacticSector_Id, t.Government_Id })
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSector_Id, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_Id, cascadeDelete: true)
                .Index(t => t.GalacticSector_Id)
                .Index(t => t.Government_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ships", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Ships", "Government_Id", "dbo.Governments");
            DropForeignKey("dbo.Ships", "CelestialBodyId_Id", "dbo.CelestialBodies");
            DropForeignKey("dbo.Structures", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Species", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Organizations", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Governments", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Events", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "CelestialBodyId_Id", "dbo.CelestialBodies");
            DropForeignKey("dbo.Species", "CelestialBodyId", "dbo.CelestialBodies");
            DropForeignKey("dbo.Organizations", "CelestialBody_Id", "dbo.CelestialBodies");
            DropForeignKey("dbo.Species", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.Organizations", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.Governments", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.Structures", "GalacticSector_Id", "dbo.GalacticSectors");
            DropForeignKey("dbo.Species", "GalacticSector_Id", "dbo.GalacticSectors");
            DropForeignKey("dbo.Organizations", "GalacticSector_Id", "dbo.GalacticSectors");
            DropForeignKey("dbo.GalacticSectorGovernments", "Government_Id", "dbo.Governments");
            DropForeignKey("dbo.GalacticSectorGovernments", "GalacticSector_Id", "dbo.GalacticSectors");
            DropForeignKey("dbo.Structures", "GalacticZone_Id", "dbo.GalacticZones");
            DropForeignKey("dbo.Species", "GalacticZone_Id", "dbo.GalacticZones");
            DropForeignKey("dbo.Organizations", "GalacticZone_Id", "dbo.GalacticZones");
            DropForeignKey("dbo.Species", "Structure_Id", "dbo.Structures");
            DropForeignKey("dbo.Structures", "SolarSystem_Id", "dbo.SolarSystems");
            DropForeignKey("dbo.Species", "SolarSystem_Id", "dbo.SolarSystems");
            DropForeignKey("dbo.Structures", "Sector_Id", "dbo.Sectors");
            DropForeignKey("dbo.Species", "Sector_Id", "dbo.Sectors");
            DropForeignKey("dbo.SolarSystems", "SectorID_Id", "dbo.Sectors");
            DropForeignKey("dbo.Structures", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.Species", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.Sectors", "RegionId_Id", "dbo.Regions");
            DropForeignKey("dbo.Organizations", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.RegionGovernments", "Government_Id", "dbo.Governments");
            DropForeignKey("dbo.RegionGovernments", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.Regions", "GalacticZoneId_Id", "dbo.GalacticZones");
            DropForeignKey("dbo.Events", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.Organizations", "Sector_Id", "dbo.Sectors");
            DropForeignKey("dbo.SectorGovernments", "Government_Id", "dbo.Governments");
            DropForeignKey("dbo.SectorGovernments", "Sector_Id", "dbo.Sectors");
            DropForeignKey("dbo.SectorEvents", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.SectorEvents", "Sector_Id", "dbo.Sectors");
            DropForeignKey("dbo.Organizations", "SolarSystem_Id", "dbo.SolarSystems");
            DropForeignKey("dbo.SolarSystemGovernments", "Government_Id", "dbo.Governments");
            DropForeignKey("dbo.SolarSystemGovernments", "SolarSystem_Id", "dbo.SolarSystems");
            DropForeignKey("dbo.Events", "SolarSystem_Id", "dbo.SolarSystems");
            DropForeignKey("dbo.CelestialBodies", "SolarSystemId", "dbo.SolarSystems");
            DropForeignKey("dbo.StructureOrganizations", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.StructureOrganizations", "Structure_Id", "dbo.Structures");
            DropForeignKey("dbo.StructureGovernments", "Government_Id", "dbo.Governments");
            DropForeignKey("dbo.StructureGovernments", "Structure_Id", "dbo.Structures");
            DropForeignKey("dbo.StructureEvents", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.StructureEvents", "Structure_Id", "dbo.Structures");
            DropForeignKey("dbo.Equipments", "Structure_Id", "dbo.Structures");
            DropForeignKey("dbo.Equipments", "OrganizationId_Id", "dbo.Organizations");
            DropForeignKey("dbo.Equipments", "GovernmentId_Id", "dbo.Governments");
            DropForeignKey("dbo.Equipments", "CelestialBodyId_Id", "dbo.CelestialBodies");
            DropForeignKey("dbo.Structures", "CelestialBodyId_Id", "dbo.CelestialBodies");
            DropForeignKey("dbo.Species", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Governments", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.GalacticZoneGovernments", "Government_Id", "dbo.Governments");
            DropForeignKey("dbo.GalacticZoneGovernments", "GalacticZone_Id", "dbo.GalacticZones");
            DropForeignKey("dbo.GalacticZones", "GalacticSectorId_Id", "dbo.GalacticSectors");
            DropForeignKey("dbo.Events", "GalacticZone_Id", "dbo.GalacticZones");
            DropForeignKey("dbo.Events", "GalacticSector_Id", "dbo.GalacticSectors");
            DropForeignKey("dbo.GovernmentCelestialBodies", "CelestialBody_Id", "dbo.CelestialBodies");
            DropForeignKey("dbo.GovernmentCelestialBodies", "Government_Id", "dbo.Governments");
            DropForeignKey("dbo.EventCelestialBodies", "CelestialBody_Id", "dbo.CelestialBodies");
            DropForeignKey("dbo.EventCelestialBodies", "Event_Id", "dbo.Events");
            DropIndex("dbo.GalacticSectorGovernments", new[] { "Government_Id" });
            DropIndex("dbo.GalacticSectorGovernments", new[] { "GalacticSector_Id" });
            DropIndex("dbo.RegionGovernments", new[] { "Government_Id" });
            DropIndex("dbo.RegionGovernments", new[] { "Region_Id" });
            DropIndex("dbo.SectorGovernments", new[] { "Government_Id" });
            DropIndex("dbo.SectorGovernments", new[] { "Sector_Id" });
            DropIndex("dbo.SectorEvents", new[] { "Event_Id" });
            DropIndex("dbo.SectorEvents", new[] { "Sector_Id" });
            DropIndex("dbo.SolarSystemGovernments", new[] { "Government_Id" });
            DropIndex("dbo.SolarSystemGovernments", new[] { "SolarSystem_Id" });
            DropIndex("dbo.StructureOrganizations", new[] { "Organization_Id" });
            DropIndex("dbo.StructureOrganizations", new[] { "Structure_Id" });
            DropIndex("dbo.StructureGovernments", new[] { "Government_Id" });
            DropIndex("dbo.StructureGovernments", new[] { "Structure_Id" });
            DropIndex("dbo.StructureEvents", new[] { "Event_Id" });
            DropIndex("dbo.StructureEvents", new[] { "Structure_Id" });
            DropIndex("dbo.GalacticZoneGovernments", new[] { "Government_Id" });
            DropIndex("dbo.GalacticZoneGovernments", new[] { "GalacticZone_Id" });
            DropIndex("dbo.GovernmentCelestialBodies", new[] { "CelestialBody_Id" });
            DropIndex("dbo.GovernmentCelestialBodies", new[] { "Government_Id" });
            DropIndex("dbo.EventCelestialBodies", new[] { "CelestialBody_Id" });
            DropIndex("dbo.EventCelestialBodies", new[] { "Event_Id" });
            DropIndex("dbo.Ships", new[] { "Organization_Id" });
            DropIndex("dbo.Ships", new[] { "Government_Id" });
            DropIndex("dbo.Ships", new[] { "CelestialBodyId_Id" });
            DropIndex("dbo.Regions", new[] { "GalacticZoneId_Id" });
            DropIndex("dbo.Sectors", new[] { "RegionId_Id" });
            DropIndex("dbo.SolarSystems", new[] { "SectorID_Id" });
            DropIndex("dbo.Equipments", new[] { "Structure_Id" });
            DropIndex("dbo.Equipments", new[] { "OrganizationId_Id" });
            DropIndex("dbo.Equipments", new[] { "GovernmentId_Id" });
            DropIndex("dbo.Equipments", new[] { "CelestialBodyId_Id" });
            DropIndex("dbo.Structures", new[] { "City_Id" });
            DropIndex("dbo.Structures", new[] { "GalacticSector_Id" });
            DropIndex("dbo.Structures", new[] { "GalacticZone_Id" });
            DropIndex("dbo.Structures", new[] { "SolarSystem_Id" });
            DropIndex("dbo.Structures", new[] { "Sector_Id" });
            DropIndex("dbo.Structures", new[] { "Region_Id" });
            DropIndex("dbo.Structures", new[] { "CelestialBodyId_Id" });
            DropIndex("dbo.Species", new[] { "City_Id" });
            DropIndex("dbo.Species", new[] { "Event_Id" });
            DropIndex("dbo.Species", new[] { "GalacticSector_Id" });
            DropIndex("dbo.Species", new[] { "GalacticZone_Id" });
            DropIndex("dbo.Species", new[] { "Structure_Id" });
            DropIndex("dbo.Species", new[] { "SolarSystem_Id" });
            DropIndex("dbo.Species", new[] { "Sector_Id" });
            DropIndex("dbo.Species", new[] { "Region_Id" });
            DropIndex("dbo.Species", new[] { "OrganizationId" });
            DropIndex("dbo.Species", new[] { "CelestialBodyId" });
            DropIndex("dbo.Organizations", new[] { "City_Id" });
            DropIndex("dbo.Organizations", new[] { "CelestialBody_Id" });
            DropIndex("dbo.Organizations", new[] { "Event_Id" });
            DropIndex("dbo.Organizations", new[] { "GalacticSector_Id" });
            DropIndex("dbo.Organizations", new[] { "GalacticZone_Id" });
            DropIndex("dbo.Organizations", new[] { "Region_Id" });
            DropIndex("dbo.Organizations", new[] { "Sector_Id" });
            DropIndex("dbo.Organizations", new[] { "SolarSystem_Id" });
            DropIndex("dbo.GalacticZones", new[] { "GalacticSectorId_Id" });
            DropIndex("dbo.Governments", new[] { "City_Id" });
            DropIndex("dbo.Governments", new[] { "Event_Id" });
            DropIndex("dbo.Governments", new[] { "Organization_Id" });
            DropIndex("dbo.Events", new[] { "City_Id" });
            DropIndex("dbo.Events", new[] { "Region_Id" });
            DropIndex("dbo.Events", new[] { "SolarSystem_Id" });
            DropIndex("dbo.Events", new[] { "GalacticZone_Id" });
            DropIndex("dbo.Events", new[] { "GalacticSector_Id" });
            DropIndex("dbo.CelestialBodies", new[] { "SolarSystemId" });
            DropIndex("dbo.Cities", new[] { "CelestialBodyId_Id" });
            DropTable("dbo.GalacticSectorGovernments");
            DropTable("dbo.RegionGovernments");
            DropTable("dbo.SectorGovernments");
            DropTable("dbo.SectorEvents");
            DropTable("dbo.SolarSystemGovernments");
            DropTable("dbo.StructureOrganizations");
            DropTable("dbo.StructureGovernments");
            DropTable("dbo.StructureEvents");
            DropTable("dbo.GalacticZoneGovernments");
            DropTable("dbo.GovernmentCelestialBodies");
            DropTable("dbo.EventCelestialBodies");
            DropTable("dbo.Ships");
            DropTable("dbo.Regions");
            DropTable("dbo.Sectors");
            DropTable("dbo.SolarSystems");
            DropTable("dbo.Equipments");
            DropTable("dbo.Structures");
            DropTable("dbo.Species");
            DropTable("dbo.Organizations");
            DropTable("dbo.GalacticZones");
            DropTable("dbo.GalacticSectors");
            DropTable("dbo.Governments");
            DropTable("dbo.Events");
            DropTable("dbo.CelestialBodies");
            DropTable("dbo.Cities");
        }
    }
}
