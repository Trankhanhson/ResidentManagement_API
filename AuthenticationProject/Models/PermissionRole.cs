using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationProject.Models
{
    public class PermissionRole
    {
        [Key]
        public long? PermissionRoleId { get; set; }

        public long? PermissionId { get; set; }

        public string? RoleId { get; set; }

        public virtual Permission? Permission { get; set; }

        [ForeignKey("RoleId")]
        public virtual IdentityRole? Role { get; set; }
    }
}
