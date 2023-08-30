using AuthenticationProject.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthenticationProject.Data
{
    public class BuildingCategoryDTO
    {
        public int CategoryId { get; set; }
        public int UrbanId { get; set; }
        public int AddressId { get; set; }
        public string? CategoryName { get; set; }
        public virtual UrbanAreaDTO? UrbanArea { get; set; }
        public virtual AddressDTO? Address { get; set; }
    }
}
