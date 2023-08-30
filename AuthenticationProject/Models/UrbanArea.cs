using System.ComponentModel.DataAnnotations;

namespace AuthenticationProject.Models
{
    public class UrbanArea
    {
        [Key]
        public int UrbanId { get; set; }
        public string? UrbanName { get; set; }
        public int? Population { get; set; }
        public virtual ICollection<BuildingCategory> buildingCategories { get; set; } = new List<BuildingCategory>();
    }
}
