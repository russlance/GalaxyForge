namespace GalaxyForge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGalaxyDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CelestialBodies",
                c => new
                    {
                        CelestialBodyId = c.Int(nullable: false, identity: true),
                        CelestialBodyName = c.String(),
                        CelestialBodyDescription = c.String(),
                        SolarSystemId = c.Int(nullable: false),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.CelestialBodyId)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystemId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .Index(t => t.SolarSystemId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventDescription = c.String(),
                        EventDate = c.Int(),
                        GalacticSector_GalacticSectorId = c.Int(),
                        GalacticZone_GalacticZoneId = c.Int(),
                        SolarSystem_SolarSystemId = c.Int(),
                        Region_RegionId = c.Int(),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSector_GalacticSectorId)
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZone_GalacticZoneId)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_SolarSystemId)
                .ForeignKey("dbo.Regions", t => t.Region_RegionId)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .Index(t => t.GalacticSector_GalacticSectorId)
                .Index(t => t.GalacticZone_GalacticZoneId)
                .Index(t => t.SolarSystem_SolarSystemId)
                .Index(t => t.Region_RegionId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.Governments",
                c => new
                    {
                        GovernmentId = c.Int(nullable: false, identity: true),
                        GovernmentName = c.String(),
                        FormationDate = c.Int(),
                        CelestialBodyId = c.Int(),
                        Organization_OrganizationId = c.Int(),
                        Event_EventId = c.Int(),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.GovernmentId)
                .ForeignKey("dbo.Organizations", t => t.Organization_OrganizationId)
                .ForeignKey("dbo.Events", t => t.Event_EventId)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .Index(t => t.Organization_OrganizationId)
                .Index(t => t.Event_EventId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.GalacticSectors",
                c => new
                    {
                        GalacticSectorId = c.Int(nullable: false, identity: true),
                        GalacticSectorName = c.String(),
                    })
                .PrimaryKey(t => t.GalacticSectorId);
            
            CreateTable(
                "dbo.GalacticZones",
                c => new
                    {
                        GalacticZoneId = c.Int(nullable: false),
                        GalacticZoneAddress = c.String(),
                        GalacticZoneName = c.String(),
                        GalacticSectorId_GalacticSectorId = c.Int(),
                    })
                .PrimaryKey(t => t.GalacticZoneId)
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSectorId_GalacticSectorId)
                .Index(t => t.GalacticSectorId_GalacticSectorId);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        OrganizationId = c.Int(nullable: false, identity: true),
                        OrganizationName = c.String(),
                        FormationDate = c.Int(),
                        OrganizationDescription = c.String(),
                        SolarSystem_SolarSystemId = c.Int(),
                        Sector_SectorID = c.Int(),
                        Region_RegionId = c.Int(),
                        GalacticZone_GalacticZoneId = c.Int(),
                        GalacticSector_GalacticSectorId = c.Int(),
                        Event_EventId = c.Int(),
                        CelestialBody_CelestialBodyId = c.Int(),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.OrganizationId)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_SolarSystemId)
                .ForeignKey("dbo.Sectors", t => t.Sector_SectorID)
                .ForeignKey("dbo.Regions", t => t.Region_RegionId)
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZone_GalacticZoneId)
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSector_GalacticSectorId)
                .ForeignKey("dbo.Events", t => t.Event_EventId)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBody_CelestialBodyId)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .Index(t => t.SolarSystem_SolarSystemId)
                .Index(t => t.Sector_SectorID)
                .Index(t => t.Region_RegionId)
                .Index(t => t.GalacticZone_GalacticZoneId)
                .Index(t => t.GalacticSector_GalacticSectorId)
                .Index(t => t.Event_EventId)
                .Index(t => t.CelestialBody_CelestialBodyId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.Species",
                c => new
                    {
                        SpeciesId = c.Int(nullable: false, identity: true),
                        SpeciesName = c.String(),
                        SpeciesDescription = c.String(),
                        CelestialBodyId = c.Int(),
                        GovernmentId = c.Int(),
                        OrganizationId = c.Int(),
                        Region_RegionId = c.Int(),
                        Sector_SectorID = c.Int(),
                        SolarSystem_SolarSystemId = c.Int(),
                        Structure_StuctureId = c.Int(),
                        GalacticZone_GalacticZoneId = c.Int(),
                        GalacticSector_GalacticSectorId = c.Int(),
                        Event_EventId = c.Int(),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.SpeciesId)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId)
                .ForeignKey("dbo.Regions", t => t.Region_RegionId)
                .ForeignKey("dbo.Sectors", t => t.Sector_SectorID)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_SolarSystemId)
                .ForeignKey("dbo.Structures", t => t.Structure_StuctureId)
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZone_GalacticZoneId)
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSector_GalacticSectorId)
                .ForeignKey("dbo.Events", t => t.Event_EventId)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBodyId)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .Index(t => t.CelestialBodyId)
                .Index(t => t.OrganizationId)
                .Index(t => t.Region_RegionId)
                .Index(t => t.Sector_SectorID)
                .Index(t => t.SolarSystem_SolarSystemId)
                .Index(t => t.Structure_StuctureId)
                .Index(t => t.GalacticZone_GalacticZoneId)
                .Index(t => t.GalacticSector_GalacticSectorId)
                .Index(t => t.Event_EventId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.Structures",
                c => new
                    {
                        StuctureId = c.Int(nullable: false, identity: true),
                        StructureName = c.String(),
                        StructureDescription = c.String(),
                        ConstructionDate = c.Int(),
                        OrganizationId = c.Int(),
                        Region_RegionId = c.Int(),
                        Sector_SectorID = c.Int(),
                        SolarSystem_SolarSystemId = c.Int(),
                        GalacticZone_GalacticZoneId = c.Int(),
                        GalacticSector_GalacticSectorId = c.Int(),
                        CelestialBody_CelestialBodyId = c.Int(),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.StuctureId)
                .ForeignKey("dbo.Regions", t => t.Region_RegionId)
                .ForeignKey("dbo.Sectors", t => t.Sector_SectorID)
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_SolarSystemId)
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZone_GalacticZoneId)
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSector_GalacticSectorId)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBody_CelestialBodyId)
                .ForeignKey("dbo.Cities", t => t.City_CityId)
                .Index(t => t.Region_RegionId)
                .Index(t => t.Sector_SectorID)
                .Index(t => t.SolarSystem_SolarSystemId)
                .Index(t => t.GalacticZone_GalacticZoneId)
                .Index(t => t.GalacticSector_GalacticSectorId)
                .Index(t => t.CelestialBody_CelestialBodyId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        EquipmentId = c.Int(nullable: false, identity: true),
                        EquipmentName = c.String(),
                        EquipmentType = c.String(),
                        EquipmentDescription = c.String(),
                        EquipmentStatus = c.String(),
                        ManufactureDate = c.Int(),
                        GovernmentId_GovernmentId = c.Int(),
                        OrganizationId_OrganizationId = c.Int(),
                        Structure_StuctureId = c.Int(),
                    })
                .PrimaryKey(t => t.EquipmentId)
                .ForeignKey("dbo.Governments", t => t.GovernmentId_GovernmentId)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId_OrganizationId)
                .ForeignKey("dbo.Structures", t => t.Structure_StuctureId)
                .Index(t => t.GovernmentId_GovernmentId)
                .Index(t => t.OrganizationId_OrganizationId)
                .Index(t => t.Structure_StuctureId);
            
            CreateTable(
                "dbo.SolarSystems",
                c => new
                    {
                        SolarSystemId = c.Int(nullable: false),
                        SolarSystemAddress = c.String(),
                        SolarSystemName = c.String(),
                        SolarSystemGalacticPlaneVariance = c.Int(),
                        SectorID_SectorID = c.Int(),
                    })
                .PrimaryKey(t => t.SolarSystemId)
                .ForeignKey("dbo.Sectors", t => t.SectorID_SectorID)
                .Index(t => t.SectorID_SectorID);
            
            CreateTable(
                "dbo.Sectors",
                c => new
                    {
                        SectorID = c.Int(nullable: false),
                        SectorAddress = c.String(),
                        SectorName = c.String(),
                        RegionId_RegionId = c.Int(),
                    })
                .PrimaryKey(t => t.SectorID)
                .ForeignKey("dbo.Regions", t => t.RegionId_RegionId)
                .Index(t => t.RegionId_RegionId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionId = c.Int(nullable: false),
                        RegionAddress = c.String(),
                        RegionName = c.String(),
                        GalacticZoneId_GalacticZoneId = c.Int(),
                    })
                .PrimaryKey(t => t.RegionId)
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZoneId_GalacticZoneId)
                .Index(t => t.GalacticZoneId_GalacticZoneId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        CityDescription = c.String(),
                        CityFoundingDate = c.Int(),
                        CelestialBodyId_CelestialBodyId = c.Int(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBodyId_CelestialBodyId)
                .Index(t => t.CelestialBodyId_CelestialBodyId);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        ShipId = c.Int(nullable: false, identity: true),
                        ShipName = c.String(),
                        ShipDescription = c.String(),
                        ConstructionDate = c.Int(),
                        Government_GovernmentId = c.Int(),
                        Organization_OrganizationId = c.Int(),
                    })
                .PrimaryKey(t => t.ShipId)
                .ForeignKey("dbo.Governments", t => t.Government_GovernmentId)
                .ForeignKey("dbo.Organizations", t => t.Organization_OrganizationId)
                .Index(t => t.Government_GovernmentId)
                .Index(t => t.Organization_OrganizationId);
            
            CreateTable(
                "dbo.EventCelestialBodies",
                c => new
                    {
                        Event_EventId = c.Int(nullable: false),
                        CelestialBody_CelestialBodyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Event_EventId, t.CelestialBody_CelestialBodyId })
                .ForeignKey("dbo.Events", t => t.Event_EventId, cascadeDelete: true)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBody_CelestialBodyId, cascadeDelete: true)
                .Index(t => t.Event_EventId)
                .Index(t => t.CelestialBody_CelestialBodyId);
            
            CreateTable(
                "dbo.GovernmentCelestialBodies",
                c => new
                    {
                        Government_GovernmentId = c.Int(nullable: false),
                        CelestialBody_CelestialBodyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Government_GovernmentId, t.CelestialBody_CelestialBodyId })
                .ForeignKey("dbo.Governments", t => t.Government_GovernmentId, cascadeDelete: true)
                .ForeignKey("dbo.CelestialBodies", t => t.CelestialBody_CelestialBodyId, cascadeDelete: true)
                .Index(t => t.Government_GovernmentId)
                .Index(t => t.CelestialBody_CelestialBodyId);
            
            CreateTable(
                "dbo.GalacticZoneGovernments",
                c => new
                    {
                        GalacticZone_GalacticZoneId = c.Int(nullable: false),
                        Government_GovernmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GalacticZone_GalacticZoneId, t.Government_GovernmentId })
                .ForeignKey("dbo.GalacticZones", t => t.GalacticZone_GalacticZoneId, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_GovernmentId, cascadeDelete: true)
                .Index(t => t.GalacticZone_GalacticZoneId)
                .Index(t => t.Government_GovernmentId);
            
            CreateTable(
                "dbo.StructureEvents",
                c => new
                    {
                        Structure_StuctureId = c.Int(nullable: false),
                        Event_EventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Structure_StuctureId, t.Event_EventId })
                .ForeignKey("dbo.Structures", t => t.Structure_StuctureId, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_EventId, cascadeDelete: true)
                .Index(t => t.Structure_StuctureId)
                .Index(t => t.Event_EventId);
            
            CreateTable(
                "dbo.StructureGovernments",
                c => new
                    {
                        Structure_StuctureId = c.Int(nullable: false),
                        Government_GovernmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Structure_StuctureId, t.Government_GovernmentId })
                .ForeignKey("dbo.Structures", t => t.Structure_StuctureId, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_GovernmentId, cascadeDelete: true)
                .Index(t => t.Structure_StuctureId)
                .Index(t => t.Government_GovernmentId);
            
            CreateTable(
                "dbo.StructureOrganizations",
                c => new
                    {
                        Structure_StuctureId = c.Int(nullable: false),
                        Organization_OrganizationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Structure_StuctureId, t.Organization_OrganizationId })
                .ForeignKey("dbo.Structures", t => t.Structure_StuctureId, cascadeDelete: true)
                .ForeignKey("dbo.Organizations", t => t.Organization_OrganizationId, cascadeDelete: true)
                .Index(t => t.Structure_StuctureId)
                .Index(t => t.Organization_OrganizationId);
            
            CreateTable(
                "dbo.SolarSystemGovernments",
                c => new
                    {
                        SolarSystem_SolarSystemId = c.Int(nullable: false),
                        Government_GovernmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SolarSystem_SolarSystemId, t.Government_GovernmentId })
                .ForeignKey("dbo.SolarSystems", t => t.SolarSystem_SolarSystemId, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_GovernmentId, cascadeDelete: true)
                .Index(t => t.SolarSystem_SolarSystemId)
                .Index(t => t.Government_GovernmentId);
            
            CreateTable(
                "dbo.SectorEvents",
                c => new
                    {
                        Sector_SectorID = c.Int(nullable: false),
                        Event_EventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sector_SectorID, t.Event_EventId })
                .ForeignKey("dbo.Sectors", t => t.Sector_SectorID, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_EventId, cascadeDelete: true)
                .Index(t => t.Sector_SectorID)
                .Index(t => t.Event_EventId);
            
            CreateTable(
                "dbo.SectorGovernments",
                c => new
                    {
                        Sector_SectorID = c.Int(nullable: false),
                        Government_GovernmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sector_SectorID, t.Government_GovernmentId })
                .ForeignKey("dbo.Sectors", t => t.Sector_SectorID, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_GovernmentId, cascadeDelete: true)
                .Index(t => t.Sector_SectorID)
                .Index(t => t.Government_GovernmentId);
            
            CreateTable(
                "dbo.RegionGovernments",
                c => new
                    {
                        Region_RegionId = c.Int(nullable: false),
                        Government_GovernmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Region_RegionId, t.Government_GovernmentId })
                .ForeignKey("dbo.Regions", t => t.Region_RegionId, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_GovernmentId, cascadeDelete: true)
                .Index(t => t.Region_RegionId)
                .Index(t => t.Government_GovernmentId);
            
            CreateTable(
                "dbo.GalacticSectorGovernments",
                c => new
                    {
                        GalacticSector_GalacticSectorId = c.Int(nullable: false),
                        Government_GovernmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GalacticSector_GalacticSectorId, t.Government_GovernmentId })
                .ForeignKey("dbo.GalacticSectors", t => t.GalacticSector_GalacticSectorId, cascadeDelete: true)
                .ForeignKey("dbo.Governments", t => t.Government_GovernmentId, cascadeDelete: true)
                .Index(t => t.GalacticSector_GalacticSectorId)
                .Index(t => t.Government_GovernmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ships", "Organization_OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Ships", "Government_GovernmentId", "dbo.Governments");
            DropForeignKey("dbo.Structures", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Species", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Organizations", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Governments", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Events", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "CelestialBodyId_CelestialBodyId", "dbo.CelestialBodies");
            DropForeignKey("dbo.CelestialBodies", "City_CityId", "dbo.Cities");
            DropForeignKey("dbo.Structures", "CelestialBody_CelestialBodyId", "dbo.CelestialBodies");
            DropForeignKey("dbo.Species", "CelestialBodyId", "dbo.CelestialBodies");
            DropForeignKey("dbo.Organizations", "CelestialBody_CelestialBodyId", "dbo.CelestialBodies");
            DropForeignKey("dbo.Species", "Event_EventId", "dbo.Events");
            DropForeignKey("dbo.Organizations", "Event_EventId", "dbo.Events");
            DropForeignKey("dbo.Governments", "Event_EventId", "dbo.Events");
            DropForeignKey("dbo.Structures", "GalacticSector_GalacticSectorId", "dbo.GalacticSectors");
            DropForeignKey("dbo.Species", "GalacticSector_GalacticSectorId", "dbo.GalacticSectors");
            DropForeignKey("dbo.Organizations", "GalacticSector_GalacticSectorId", "dbo.GalacticSectors");
            DropForeignKey("dbo.GalacticSectorGovernments", "Government_GovernmentId", "dbo.Governments");
            DropForeignKey("dbo.GalacticSectorGovernments", "GalacticSector_GalacticSectorId", "dbo.GalacticSectors");
            DropForeignKey("dbo.Structures", "GalacticZone_GalacticZoneId", "dbo.GalacticZones");
            DropForeignKey("dbo.Species", "GalacticZone_GalacticZoneId", "dbo.GalacticZones");
            DropForeignKey("dbo.Organizations", "GalacticZone_GalacticZoneId", "dbo.GalacticZones");
            DropForeignKey("dbo.Species", "Structure_StuctureId", "dbo.Structures");
            DropForeignKey("dbo.Structures", "SolarSystem_SolarSystemId", "dbo.SolarSystems");
            DropForeignKey("dbo.Species", "SolarSystem_SolarSystemId", "dbo.SolarSystems");
            DropForeignKey("dbo.Structures", "Sector_SectorID", "dbo.Sectors");
            DropForeignKey("dbo.Species", "Sector_SectorID", "dbo.Sectors");
            DropForeignKey("dbo.SolarSystems", "SectorID_SectorID", "dbo.Sectors");
            DropForeignKey("dbo.Structures", "Region_RegionId", "dbo.Regions");
            DropForeignKey("dbo.Species", "Region_RegionId", "dbo.Regions");
            DropForeignKey("dbo.Sectors", "RegionId_RegionId", "dbo.Regions");
            DropForeignKey("dbo.Organizations", "Region_RegionId", "dbo.Regions");
            DropForeignKey("dbo.RegionGovernments", "Government_GovernmentId", "dbo.Governments");
            DropForeignKey("dbo.RegionGovernments", "Region_RegionId", "dbo.Regions");
            DropForeignKey("dbo.Regions", "GalacticZoneId_GalacticZoneId", "dbo.GalacticZones");
            DropForeignKey("dbo.Events", "Region_RegionId", "dbo.Regions");
            DropForeignKey("dbo.Organizations", "Sector_SectorID", "dbo.Sectors");
            DropForeignKey("dbo.SectorGovernments", "Government_GovernmentId", "dbo.Governments");
            DropForeignKey("dbo.SectorGovernments", "Sector_SectorID", "dbo.Sectors");
            DropForeignKey("dbo.SectorEvents", "Event_EventId", "dbo.Events");
            DropForeignKey("dbo.SectorEvents", "Sector_SectorID", "dbo.Sectors");
            DropForeignKey("dbo.Organizations", "SolarSystem_SolarSystemId", "dbo.SolarSystems");
            DropForeignKey("dbo.SolarSystemGovernments", "Government_GovernmentId", "dbo.Governments");
            DropForeignKey("dbo.SolarSystemGovernments", "SolarSystem_SolarSystemId", "dbo.SolarSystems");
            DropForeignKey("dbo.Events", "SolarSystem_SolarSystemId", "dbo.SolarSystems");
            DropForeignKey("dbo.CelestialBodies", "SolarSystemId", "dbo.SolarSystems");
            DropForeignKey("dbo.StructureOrganizations", "Organization_OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.StructureOrganizations", "Structure_StuctureId", "dbo.Structures");
            DropForeignKey("dbo.StructureGovernments", "Government_GovernmentId", "dbo.Governments");
            DropForeignKey("dbo.StructureGovernments", "Structure_StuctureId", "dbo.Structures");
            DropForeignKey("dbo.StructureEvents", "Event_EventId", "dbo.Events");
            DropForeignKey("dbo.StructureEvents", "Structure_StuctureId", "dbo.Structures");
            DropForeignKey("dbo.Equipments", "Structure_StuctureId", "dbo.Structures");
            DropForeignKey("dbo.Equipments", "OrganizationId_OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Equipments", "GovernmentId_GovernmentId", "dbo.Governments");
            DropForeignKey("dbo.Species", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Governments", "Organization_OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.GalacticZoneGovernments", "Government_GovernmentId", "dbo.Governments");
            DropForeignKey("dbo.GalacticZoneGovernments", "GalacticZone_GalacticZoneId", "dbo.GalacticZones");
            DropForeignKey("dbo.GalacticZones", "GalacticSectorId_GalacticSectorId", "dbo.GalacticSectors");
            DropForeignKey("dbo.Events", "GalacticZone_GalacticZoneId", "dbo.GalacticZones");
            DropForeignKey("dbo.Events", "GalacticSector_GalacticSectorId", "dbo.GalacticSectors");
            DropForeignKey("dbo.GovernmentCelestialBodies", "CelestialBody_CelestialBodyId", "dbo.CelestialBodies");
            DropForeignKey("dbo.GovernmentCelestialBodies", "Government_GovernmentId", "dbo.Governments");
            DropForeignKey("dbo.EventCelestialBodies", "CelestialBody_CelestialBodyId", "dbo.CelestialBodies");
            DropForeignKey("dbo.EventCelestialBodies", "Event_EventId", "dbo.Events");
            DropIndex("dbo.GalacticSectorGovernments", new[] { "Government_GovernmentId" });
            DropIndex("dbo.GalacticSectorGovernments", new[] { "GalacticSector_GalacticSectorId" });
            DropIndex("dbo.RegionGovernments", new[] { "Government_GovernmentId" });
            DropIndex("dbo.RegionGovernments", new[] { "Region_RegionId" });
            DropIndex("dbo.SectorGovernments", new[] { "Government_GovernmentId" });
            DropIndex("dbo.SectorGovernments", new[] { "Sector_SectorID" });
            DropIndex("dbo.SectorEvents", new[] { "Event_EventId" });
            DropIndex("dbo.SectorEvents", new[] { "Sector_SectorID" });
            DropIndex("dbo.SolarSystemGovernments", new[] { "Government_GovernmentId" });
            DropIndex("dbo.SolarSystemGovernments", new[] { "SolarSystem_SolarSystemId" });
            DropIndex("dbo.StructureOrganizations", new[] { "Organization_OrganizationId" });
            DropIndex("dbo.StructureOrganizations", new[] { "Structure_StuctureId" });
            DropIndex("dbo.StructureGovernments", new[] { "Government_GovernmentId" });
            DropIndex("dbo.StructureGovernments", new[] { "Structure_StuctureId" });
            DropIndex("dbo.StructureEvents", new[] { "Event_EventId" });
            DropIndex("dbo.StructureEvents", new[] { "Structure_StuctureId" });
            DropIndex("dbo.GalacticZoneGovernments", new[] { "Government_GovernmentId" });
            DropIndex("dbo.GalacticZoneGovernments", new[] { "GalacticZone_GalacticZoneId" });
            DropIndex("dbo.GovernmentCelestialBodies", new[] { "CelestialBody_CelestialBodyId" });
            DropIndex("dbo.GovernmentCelestialBodies", new[] { "Government_GovernmentId" });
            DropIndex("dbo.EventCelestialBodies", new[] { "CelestialBody_CelestialBodyId" });
            DropIndex("dbo.EventCelestialBodies", new[] { "Event_EventId" });
            DropIndex("dbo.Ships", new[] { "Organization_OrganizationId" });
            DropIndex("dbo.Ships", new[] { "Government_GovernmentId" });
            DropIndex("dbo.Cities", new[] { "CelestialBodyId_CelestialBodyId" });
            DropIndex("dbo.Regions", new[] { "GalacticZoneId_GalacticZoneId" });
            DropIndex("dbo.Sectors", new[] { "RegionId_RegionId" });
            DropIndex("dbo.SolarSystems", new[] { "SectorID_SectorID" });
            DropIndex("dbo.Equipments", new[] { "Structure_StuctureId" });
            DropIndex("dbo.Equipments", new[] { "OrganizationId_OrganizationId" });
            DropIndex("dbo.Equipments", new[] { "GovernmentId_GovernmentId" });
            DropIndex("dbo.Structures", new[] { "City_CityId" });
            DropIndex("dbo.Structures", new[] { "CelestialBody_CelestialBodyId" });
            DropIndex("dbo.Structures", new[] { "GalacticSector_GalacticSectorId" });
            DropIndex("dbo.Structures", new[] { "GalacticZone_GalacticZoneId" });
            DropIndex("dbo.Structures", new[] { "SolarSystem_SolarSystemId" });
            DropIndex("dbo.Structures", new[] { "Sector_SectorID" });
            DropIndex("dbo.Structures", new[] { "Region_RegionId" });
            DropIndex("dbo.Species", new[] { "City_CityId" });
            DropIndex("dbo.Species", new[] { "Event_EventId" });
            DropIndex("dbo.Species", new[] { "GalacticSector_GalacticSectorId" });
            DropIndex("dbo.Species", new[] { "GalacticZone_GalacticZoneId" });
            DropIndex("dbo.Species", new[] { "Structure_StuctureId" });
            DropIndex("dbo.Species", new[] { "SolarSystem_SolarSystemId" });
            DropIndex("dbo.Species", new[] { "Sector_SectorID" });
            DropIndex("dbo.Species", new[] { "Region_RegionId" });
            DropIndex("dbo.Species", new[] { "OrganizationId" });
            DropIndex("dbo.Species", new[] { "CelestialBodyId" });
            DropIndex("dbo.Organizations", new[] { "City_CityId" });
            DropIndex("dbo.Organizations", new[] { "CelestialBody_CelestialBodyId" });
            DropIndex("dbo.Organizations", new[] { "Event_EventId" });
            DropIndex("dbo.Organizations", new[] { "GalacticSector_GalacticSectorId" });
            DropIndex("dbo.Organizations", new[] { "GalacticZone_GalacticZoneId" });
            DropIndex("dbo.Organizations", new[] { "Region_RegionId" });
            DropIndex("dbo.Organizations", new[] { "Sector_SectorID" });
            DropIndex("dbo.Organizations", new[] { "SolarSystem_SolarSystemId" });
            DropIndex("dbo.GalacticZones", new[] { "GalacticSectorId_GalacticSectorId" });
            DropIndex("dbo.Governments", new[] { "City_CityId" });
            DropIndex("dbo.Governments", new[] { "Event_EventId" });
            DropIndex("dbo.Governments", new[] { "Organization_OrganizationId" });
            DropIndex("dbo.Events", new[] { "City_CityId" });
            DropIndex("dbo.Events", new[] { "Region_RegionId" });
            DropIndex("dbo.Events", new[] { "SolarSystem_SolarSystemId" });
            DropIndex("dbo.Events", new[] { "GalacticZone_GalacticZoneId" });
            DropIndex("dbo.Events", new[] { "GalacticSector_GalacticSectorId" });
            DropIndex("dbo.CelestialBodies", new[] { "City_CityId" });
            DropIndex("dbo.CelestialBodies", new[] { "SolarSystemId" });
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
            DropTable("dbo.Cities");
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
        }
    }
}
