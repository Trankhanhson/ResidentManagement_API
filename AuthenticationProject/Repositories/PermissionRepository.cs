using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;

namespace AuthenticationProject.Repositories
{
    public class PermissionRepository : GenericRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(AuthenticationDBContext authenticationDBContext) : base(authenticationDBContext) { }

        public async Task UpdatePermission(Permission Permission)
        {
            try
            {
                var entity = await _context.Permissions.Include(a => a.PermissionRoles).Where(r => r.PermissionId == Permission.PermissionId).FirstAsync();
                entity.Name = Permission.Name;
                var PermissionRoleDeletes = entity.PermissionRoles.Where(a=>!Permission.PermissionRoles.Any(r => r.RoleId == a.RoleId)).ToList();
                _context.PermissionRoles.RemoveRange(PermissionRoleDeletes);

                var PermissionAdds = Permission.PermissionRoles.Where(a => !entity.PermissionRoles.Any(pr => pr.RoleId == a.RoleId));
                _context.PermissionRoles.AddRange(PermissionAdds);
                
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while accessing the database. ", ex);
            }
        }


        public void DeletePermission(int id)
        {
            try
            {
                var entity =  _context.Permissions.Include(a => a.PermissionUsers).Include(a=>a.PermissionRoles).Where(r => r.PermissionId ==id).First();

                if (entity.PermissionUsers.Count > 0)
                {
                    _context.PermissionUsers.RemoveRange(entity.PermissionUsers);
                }
                if (entity.PermissionRoles.Count > 0)
                {
                    _context.PermissionRoles.RemoveRange(entity.PermissionRoles);
                }
                _context.Permissions.Remove(entity);

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while accessing the database. ", ex);
            }
        }

        public void DeleteMutiplePermission(List<Permission> Permissions)
        {
            foreach (var item in Permissions)
            {
                var entity = _context.Permissions.Include(a => a.PermissionUsers).Include(a => a.PermissionRoles).Where(r => r.PermissionId == item.PermissionId).First();

                if (entity.PermissionUsers.Count > 0)
                {
                    _context.PermissionUsers.RemoveRange(entity.PermissionUsers);
                }
                if (entity.PermissionRoles.Count > 0)
                {
                    _context.PermissionRoles.RemoveRange(entity.PermissionRoles);
                }
                _context.Permissions.Remove(entity);
            }
        }

        public Permission GetPermissions(int id)
        {
            return _context.Permissions.Include(a => a.PermissionRoles).Where(r => r.PermissionId == id).First();
        }

        public async Task<IEnumerable<Permission>> GetAllPermissions()
        {
            return _context.Permissions.Include(a => a.PermissionRoles).Select(p=>new Permission()
            {
                PermissionId = p.PermissionId,
                Name = p.Name,
                PermissionRoles = p.PermissionRoles.Select(p =>new PermissionRole() { Role = p.Role}).ToList()
            }).ToList();
        }

        public async Task<IEnumerable<IdentityRole>> GetAllRole()
        {
            var list = await _context.Roles.Select(a=>new IdentityRole()
            {
                Id = a.Id,
                Name = a.Name
            }).ToListAsync();
            return list;

        }
    }
}
