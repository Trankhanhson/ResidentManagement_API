using AuthenticationProject.Data;
using AuthenticationProject.Models;
using Microsoft.AspNetCore.Identity;
namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IUserRepository 
    {
         Task<string> CreateUser(SignUpModel model);
         Task UpdateUser(SignUpModel model);
         Task DeleteUser(string id);

         void DeleteMultipleUser(List<SignUpModel> models);

         Task<IEnumerable<SignUpModel>> GetAll();

    }
}
