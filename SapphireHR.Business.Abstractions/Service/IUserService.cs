using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IUserService
    {
        Task<UserModel> CreateUserAsync(UserModel model, IEnumerable<string> roleNames);
        Task<UserModel> GetUserById(string userId);
        Task<bool> UpdateUser(UserModel user, IEnumerable<string> roleNames);
        Task ForgotPassword(EmailModel model);
        Task ResendVerificationEmail(EmailModel model);
        Task ResetPassword(ResetPasswordModel model);
        Task<UserModel> FindByEmailAsync(string email);
        Task<UserModel> FindByIdAsync(string email);
        Task<UserModel> FindByUserNameAsync(string email);
        Task<IList<Claim>> GetClaimsAsync(UserModel user);
        Task<IList<string>> GetRolesAsync(UserModel user);
        Task<bool> CheckPasswordAsync(UserModel user, string Password);
        Task<IEnumerable<string>> GetRoles();
        Task AddRole(string roleName);
        Task RemoveUser(string userId);
    }
}
