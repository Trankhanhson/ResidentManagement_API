using AuthenticationProject.Models;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IPermissionRepository : IGenericRepository<Permission>
    {
        Task UpdatePermission(Permission Permission);

        void DeletePermission(int id);

        void DeleteMutiplePermission(List<Permission> Permissions);

        Permission GetPermissions(int id);

        Task<IEnumerable<Permission>> GetAllPermissions();

        Task<IEnumerable<IdentityRole>> GetAllRole();
    }
}
