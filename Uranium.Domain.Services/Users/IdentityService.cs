using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Uranium.Domain.Core.Entities.User;
using Uranium.Domain.Core.Results;

namespace Uranium.Domain.Services.Users
{
    public interface IUserManager
    {
        Task<SucceededResult> Create(User user);

        Task<bool> HasRole(string userId, Role role);
        Task<List<Role>> GetRoles(string userId);
        Task<SucceededResult> SetRoles(User user, IList<Role> roles);

        Task<bool> IsBlocked(string userId);
        void SetBlocked(User user, bool blocked);

        Task<User?> FindById(string userId);
        Task<User?> FindByUserName(string userName);
        Task<User?> FindByEmail(string email);

        Task<string> GenerateResetPasswordToken(string userId);
        Task<string> GenerateResetPasswordToken(User user);
        Task<SucceededResult> ResetPassword(User user, string token, string newPassword);

        Task<DateTime> GetLastActivity(string userId);
        Task<bool> IsOnline(string userId);
    }

    public class IdentityService : IUserManager
    {
        public Task<SucceededResult> Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User?> FindByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User?> FindById(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<User?> FindByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GenerateResetPasswordToken(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GenerateResetPasswordToken(User user)
        {
            throw new NotImplementedException();
        }

        public Task<DateTime> GetLastActivity(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Role>> GetRoles(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasRole(string userId, Role role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsBlocked(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsOnline(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<SucceededResult> ResetPassword(User user, string token, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void SetBlocked(User user, bool blocked)
        {
            throw new NotImplementedException();
        }

        public Task<SucceededResult> SetRoles(User user, IList<Role> roles)
        {
            throw new NotImplementedException();
        }
    }
}
