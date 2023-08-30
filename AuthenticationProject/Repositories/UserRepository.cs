using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AuthenticationProject.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public readonly AuthenticationDBContext _dbContext;
        public UserRepository(UserManager<ApplicationUser> userManager,AuthenticationDBContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public async Task<string> CreateUser(SignUpModel model)
        {
            var userExist = await _userManager.FindByEmailAsync(model.Email);
            if (userExist != null)
            {
                return "ExistMail";
            }
            var user = new ApplicationUser { UserName = model.Email, Email = model.Email, LastName = model.LastName, FirstName = model.FirstName };
            var result = await _userManager.CreateAsync(user, model.Password);
            //assign permission
            foreach(var item in model.PermissionUsers)
            {
                item.UserId = user.Id;
            }
            _dbContext.AddRange(model.PermissionUsers);
            _dbContext.SaveChangesAsync();
            return user.Id;
        }

        public async void DeleteMultipleUser(List<SignUpModel> models)
        {
            var listPermissionUser = _dbContext.PermissionUsers.ToList();
            foreach (var model in models)
            {
                var listPermissionUserDelete = listPermissionUser.Where(a => a.UserId == model.Id).ToList();
                _dbContext.PermissionUsers.RemoveRange(listPermissionUserDelete);
                var a = _dbContext.Users.Find(model.Id);
                _dbContext.Users.Remove(a);
            }
            _dbContext.SaveChanges();
        }

        public async Task DeleteUser(string id)
        {
            var a = _dbContext.Users.Find(id);
            var listPermissionUser = _dbContext.PermissionUsers.Where(x => x.UserId == id).ToList();
            _dbContext.PermissionUsers.RemoveRange(listPermissionUser);
            _dbContext.Users.Remove(a);
            _dbContext.SaveChanges();
        }

        public async Task<IEnumerable<SignUpModel>> GetAll()
        {
            var PermissionUserAll = _dbContext.PermissionUsers.Include(a=>a.Permission).ToList();
            var users = await _dbContext.Users.ToListAsync();
            var signUpModels = users.Select(a => new SignUpModel
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Email = a.Email,
                Password = a.PasswordHash,
                PermissionUsers = PermissionUserAll.Where(b => b.UserId == a.Id).Select(p => new PermissionUser() { PermissionId = p.PermissionId, Permission = new Permission() { Name = p.Permission.Name } }).ToList()
            }).ToList();
            return signUpModels;

        }


        public async Task UpdateUser(SignUpModel model)
        {
            var user =  (ApplicationUser)_userManager.FindByIdAsync(model.Id).Result;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.UserName = model.Email;
            user.Email = model.Email;

            var applicationUser = new ApplicationUser {Id = model.Id, UserName = model.Email, Email = model.Email, LastName = model.LastName, FirstName = model.FirstName };
            if (!string.IsNullOrEmpty(model.NewPassword))
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(applicationUser, model.NewPassword);
            }
            _dbContext.SaveChanges();
            var listDelete = _dbContext.PermissionUsers.Where(a => a.UserId == model.Id).ToList();
             _dbContext.PermissionUsers.RemoveRange(listDelete);
            await _dbContext.PermissionUsers.AddRangeAsync(model.PermissionUsers);
            _dbContext.SaveChanges();
            
        }

    }
}
