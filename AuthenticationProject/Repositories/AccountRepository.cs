using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.WebSockets;
using System.Security.Claims;
using System.Text;
using AuthenticationProject.common;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;
namespace AuthenticationProject.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IConfiguration _configuration;
        private readonly AuthenticationDBContext _authenticationDBContext;
        private readonly CacheHelper _cacheHelper;

        public AccountRepository(CacheHelper cacheHelper, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration,AuthenticationDBContext authenticationDBContext)
        {
            _userManager = userManager;
            this.signInManager = signInManager;
            _configuration = configuration;
            _authenticationDBContext = authenticationDBContext;
            _cacheHelper = cacheHelper;
        }


        public async Task<(string, List<string>)> SignInAsync(SignInModel model)
        {

            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            if (!result.Succeeded)
            {
                return (string.Empty,new List<string>());
            }

            var user = await _authenticationDBContext.Users.Where(a=>a.Email == model.Email).FirstAsync();
            if (user == null)
            {
                return (string.Empty,new List<string>());
            }
            var permissions = getRoleById(user.Id);
            //Đưa role vào cache
            _cacheHelper.Set($"Permission_{user.Id}", permissions);
            var authClaims = new List<Claim>
            {
                //danh sach quyen
                new Claim(ClaimTypes.Email,model.Email),
                new Claim(ClaimTypes.NameIdentifier,user.Id),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
            );
            return (new JwtSecurityTokenHandler().WriteToken(token),permissions);
        }

        public List<string> getRoleById(string UserId)
        {
            var roles = _authenticationDBContext.PermissionUsers.Where(b => b.UserId == UserId)
                .SelectMany(u=>u.Permission.PermissionRoles.Select(pr=>pr.Role.Name)).ToList();
            return roles;
        }
    }
}
