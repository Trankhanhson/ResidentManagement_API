using AuthenticationProject.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationProject.Data
{
    public class ApartmentDTO
    {
        public int ApartmentId { get; set; }
        public string? ApartmentName { get; set; }

        public int CategoryId { get; set; }
        public string? Building { get; set; }

        public int? Space { get; set; }

        public int? Floor { get; set; }
        public virtual BuildingCategoryDTO? BuildingCategory { get; set; }
    }
}
