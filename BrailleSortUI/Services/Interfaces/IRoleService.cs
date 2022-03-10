using BrailleSortLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Databases.Services
{
    public interface IRoleService
    {
        public Task<bool> IsUserInRoleAsync(UserModel user, string roleName);

        public Task<IEnumerable<string>> GetUserRolesAsync(UserModel usser);

        public Task<bool> AddUserToRoleAsync(UserModel user, IEnumerable<string> roles);

        public Task<bool> RemoveUserFromRoleAsync(UserModel user, string roleName);

        public Task<bool> RemoveUserFromRolesAsync(UserModel user, IEnumerable<string> roles);

        public Task<List<UserModel>> GetUsersInRoleAsync(string roleName, int teamId);

        public Task<List<UserModel>> GetUserNotInRoleAsync(string roleName, int teamId);

        public Task<string> GetRoleNameByIdAsync(string roleId);
    }
}
