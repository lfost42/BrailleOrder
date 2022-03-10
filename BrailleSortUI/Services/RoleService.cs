using BrailleSortLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrailleSortLibrary.Databases.Services
{
    public class RoleService : IRoleService
    {
        //public RoleService(ApplicationDbContext context)
        //{

        //}

        public Task<bool> AddUserToRoleAsync(UserModel user, IEnumerable<string> roles)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoleNameByIdAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> GetUserNotInRoleAsync(string roleName, int teamId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetUserRolesAsync(UserModel usser)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> GetUsersInRoleAsync(string roleName, int teamId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserInRoleAsync(UserModel user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveUserFromRoleAsync(UserModel user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveUserFromRolesAsync(UserModel user, IEnumerable<string> roles)
        {
            throw new NotImplementedException();
        }
    }
}
