using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AuthenticationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        public AuthController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        //[HttpPost("SignUp")]
        //public async Task<IActionResult> SignUp(SignUpModel model)
        //{
        //    var result = await _accountRepository.SignUpAsync(model);
        //    if (result.Succeeded)
        //    {
        //        return Ok(result.Succeeded);
        //    }
        //    return Unauthorized();
        //}
        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            var result = await _accountRepository.SignInAsync(model);
            if (string.IsNullOrEmpty(result.Item1))
            {
                return Unauthorized();
            }
            return Ok(JsonConvert.SerializeObject(new
            {
                token = result.Item1,
                permissions = result.Item2
            }));
        }
    }
}
