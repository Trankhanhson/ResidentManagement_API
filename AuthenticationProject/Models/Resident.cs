using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthenticationProject.Models
{
    public class Resident
    {
        [Key]
        public int ResidentId { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? Cccd { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? Gender { get; set; }

        public virtual ICollection<ResidentApartment> ResidentApartments { get; set; } = new List<ResidentApartment>();
    }
}
