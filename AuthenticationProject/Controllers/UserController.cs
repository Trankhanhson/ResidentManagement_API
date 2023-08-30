using AuthenticationProject.common;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AuthenticationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _res;

        public UserController(IUserRepository res)
        {
            _res = res;
        }

        [HttpGet]
        [Route("GetAll")]
        [CustomAuthorize("User_GetAll", typeof(CacheHelper))]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var authFeature = HttpContext.Features.Get<IAuthenticationFeature>();
                var list = _res.GetAll().Result;
                return Ok(JsonConvert.SerializeObject(list, Formatting.None, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                }));
            }
            catch
            {
                return Ok(false);
            }
        }



        [HttpPost]
        [Route("Create")]
        [CustomAuthorize("User_Create", typeof(CacheHelper))]
        public async Task<IActionResult> Create(SignUpModel model)
        {
            try
            {
                if(model == null)
                {
                    return BadRequest();
                }
                var id = _res.CreateUser(model).Result;
                return Ok(JsonConvert.SerializeObject(id));
            }
            catch {
                return Ok(false);
            }
        }

        [HttpPost]
        [Route("Update")]
        [CustomAuthorize("User_Update", typeof(CacheHelper))]
        public async Task<IActionResult> Update(SignUpModel model)
        {
            try
            {
                _res.UpdateUser(model);
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }


        [HttpGet]
        [Route("Delete/{id}")]
        [CustomAuthorize("User_Delete", typeof(CacheHelper))]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                _res.DeleteUser(id);
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }

        [HttpPost]
        [Route("DeleteMultiple")]
        [CustomAuthorize("User_DeleteMultiple", typeof(CacheHelper))]
        public async Task<IActionResult> DeleteMultiple(List<SignUpModel> models)
        {
            try
            {
                _res.DeleteMultipleUser(models);
                return Ok(true);
            }
            catch
            {
                return Ok(false);
            }
        }
    }
}
