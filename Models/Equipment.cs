namespace GalaxyForge.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string? EquipmentName { get; set; }
        public string? EquipmentType { get; set; }
        public string? EquipmentDescription { get; set; }
        public string? EquipmentStatus { get; set; }
        public int? ManufactureDate { get; set; }

        public virtual Government? GovernmentId { get; set; }
        public virtual Organization? OrganizationId { get; set; }
    }
}