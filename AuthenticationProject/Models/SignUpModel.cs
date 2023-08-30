using System.ComponentModel.DataAnnotations;

namespace AuthenticationProject.Models
{
    public class SignUpModel
    {
        public string? Id { get; set; }
        [Required]
        public string? FirstName { get; set; } = null!;
        [Required]
        public string? LastName { get; set; } = null!;
        [Required, EmailAddress]
        public string? Email { get; set; } = null!;


        [Required]
        public string? Password { get; set; } = null!;
        public string? NewPassword { get; set; } = null!;
        
        public string? ConfirmPassword { get; set; } 

        [Required]
        public List<PermissionUser>? PermissionUsers { get; set; } = null!;
    }
}
