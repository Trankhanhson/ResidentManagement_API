using AuthenticationProject.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthenticationProject.Data
{
    public class ResidentDTO
    {
        public int? ResidentId { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? Cccd { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? Gender { get; set; }

        public virtual ICollection<ResidentApartmentDTO> ResidentApartments { get; set; }
    }
}
