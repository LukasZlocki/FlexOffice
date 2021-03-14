using System.Collections.Generic;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{
    public class UserService : IUserService
    {

        public UserService()
        {
            
        }

        // CREATE
        public ServiceResponse<AppUser> AddUser(AppUser user)
        {
            throw new System.NotImplementedException();
        }

        // READ
        public List<AppUser> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public AppUser GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        // UPDATE
        public ServiceResponse<bool> UpdateUser(int userId)
        {
            throw new System.NotImplementedException();
        }

        // DELETE
        public ServiceResponse<bool> DeleteUser(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}