using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthenticationProject.Models
{
    public class Customer
    {
        [Key]
        public long? Makhachhang { get; set; }

        public string? Tenkhachhang { get; set; }

        public string? Cccd { get; set; }

        public DateTime? Ngaycap { get; set; }

        public string? Hinhanh { get; set; }

        public string? Sodienthoai { get; set; }

        public string? Email { get; set; }

        public string? Diachi { get; set; }

        [NotMapped]
        public IFormFile? FileImage { get; set; }
    }
}
