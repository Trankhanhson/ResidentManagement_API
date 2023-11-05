using AuthenticationProject.common;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AuthenticationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionRepository _permissionRepository;
        public PermissionController(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        [HttpGet]
        [Route("GetAll_Role")]

        public async Task<IActionResult> GetAllRole()
        {
            return Ok(JsonConvert.SerializeObject(_permissionRepository.GetAllRole().Result, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }));
        }
        [HttpPost]
        [Route("Create")]
        //[CustomAuthorize("Permission_Create", typeof(CacheHelper))]
        public async Task<IActionResult> Create([FromBody] Permission permission)
        {
            try
            {
                if (permission == null)
                {
                    return BadRequest("permission data is invalid");
                }
                var entity = await _permissionRepository.Add(permission);
                _permissionRepository.Complete();
                return Ok(entity.PermissionId);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }

        [HttpPost]
        [Route("Update")]
        //[CustomAuthorize("Permission_Update", typeof(CacheHelper))]
        public async Task<IActionResult> Update(Permission permission)
        {
            try
            {

                await _permissionRepository.UpdatePermission(permission);
                _permissionRepository.Complete();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }

        [HttpGet]
        [Route("Delete/{id}")]
        //[CustomAuthorize("Permission_Delete", typeof(CacheHelper))]
        public IActionResult Delete(int id)
        {
            try
            {
                _permissionRepository.DeletePermission(id);
                _permissionRepository.Complete();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }


        [HttpPost]
        [Route("DeleteMultiple")]
        //[CustomAuthorize("Permission_DeleteMultiple", typeof(CacheHelper))]
        public IActionResult DeleteMulti(List<Permission> permissions)
        {
            try
            {
                _permissionRepository.DeleteMutiplePermission(permissions);
                _permissionRepository.Complete();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return Ok(false);
            }
        }


        [HttpGet]
        [Route("GetAll")]
        //[CustomAuthorize("Permission_GetAll", typeof(CacheHelper))]
        public async Task<IActionResult> GetAll()
        {
            var list = _permissionRepository.GetAllPermissions();
            return Ok(JsonConvert.SerializeObject(list, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }));
        }


        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var etity = _permissionRepository.GetPermissions(id);
                return Ok(JsonConvert.SerializeObject(new
                {
                    PermissionId = etity.PermissionId,
                    Name = etity.Name,
                    PermissionRoles = etity.PermissionRoles.Select(a=>a.RoleId).ToList()
                }));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred.");
            }

        }
    }
}
