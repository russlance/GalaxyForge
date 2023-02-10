namespace GalaxyForge.Models
{
    public class Ship
    {
        public int ShipId { get; set; }
        public string? ShipName { get; set; }
        public string? ShipDescription { get; set; }
        public int? ConstructionDate { get; set; }

        public Organization? Organization { get; set; }
        public Government? Government { get; set; }
    }
}