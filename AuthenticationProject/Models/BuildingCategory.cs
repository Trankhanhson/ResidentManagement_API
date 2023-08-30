using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthenticationProject.Models
{
    public class BuildingCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public int UrbanId { get; set; }
        public int AddressId { get; set; }
        public string? CategoryName { get; set; }
        [ForeignKey("UrbanId")]
        public virtual UrbanArea? UrbanArea { get; set; }
        public virtual Address? Address { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();
    }
}
