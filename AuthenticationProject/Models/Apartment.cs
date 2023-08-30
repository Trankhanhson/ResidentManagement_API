using AuthenticationProject.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthenticationProject.Models
{
    public class Apartment
    {
        [Key]
        public int ApartmentId { get; set; }
        public string? ApartmentName { get; set; }

        public int CategoryId { get; set; }
        public string? Building { get; set; }

        public int? Space { get; set; }

        public int? Floor { get; set; }

        public virtual ICollection<ResidentApartment> ResidentApartments { get; set; } = new List<ResidentApartment>();

        [ForeignKey("CategoryId")]
        public virtual BuildingCategory? BuildingCategory { get; set; }

    }
}
