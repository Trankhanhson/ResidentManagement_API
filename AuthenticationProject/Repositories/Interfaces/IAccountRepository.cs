using AuthenticationProject.Models;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationProject.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        //Task<IdentityResult> SignUpAsync(SignUpModel model);
        Task<(string,List<string>)> SignInAsync(SignInModel model);
    }
}
