using System.ComponentModel.DataAnnotations;
using System.Security;

namespace AuthenticationProject.Models
{
    public class Permission
    {
        [Key]
        public long PermissionId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<PermissionUser> PermissionUsers { get; set; } = new List<PermissionUser>();
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; } = new List<PermissionRole>();
    }
}
