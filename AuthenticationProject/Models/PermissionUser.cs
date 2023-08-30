using AuthenticationProject.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationProject.Models
{
    public class PermissionUser
    {
        [Key]
        public long? PermissionUserId { get; set; }

        public string? UserId { get; set; }

        public long? PermissionId { get; set; }

        public virtual Permission? Permission { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser? User { get; set; }
    }
}
