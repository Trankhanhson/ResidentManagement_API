using System.ComponentModel.DataAnnotations;

namespace AuthenticationProject.Models
{
        public class Address
        {
            [Key]
            public int AddressId { get; set; }
            public string? Street { get; set; }
            public string? Commune { get; set; }
            public string? District { get; set; }
            public string? City { get; set; }
            public virtual ICollection<BuildingCategory> buildingCategories { get; set; } = new List<BuildingCategory>();
        }
}
