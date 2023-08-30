using AuthenticationProject.Models;

namespace AuthenticationProject.Data
{
    public class ResidentApartmentDTO
    {
        public int? ResidentApartmentId { get; set; }

        public int? ApartmentId { get; set; }

        public int? ResidentId { get; set; }

        public virtual ApartmentDTO? Apartment { get; set; }
    }
}
