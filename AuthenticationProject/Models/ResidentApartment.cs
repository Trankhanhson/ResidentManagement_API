

namespace AuthenticationProject.Models
{
    public class ResidentApartment
    {
        public int ResidentApartmentId { get; set; }

        public int? ApartmentId { get; set; }

        public int? ResidentId { get; set; }

        public virtual Apartment? Apartment { get; set; }

        public virtual Resident? Resident { get; set; }
    }
}
