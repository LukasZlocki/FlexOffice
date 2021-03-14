using System.Collections.Generic;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{
    public interface IUserService
    {
        // CREATE
        public ServiceResponse<Data.Models.AppUser> AddUser(Data.Models.AppUser user);

        // READ
        public AppUser GetUserById(int id);
        public List<AppUser> GetAllUsers();

        // UPDATE
        public ServiceResponse<bool> UpdateUser(int userId);

        // DELETE
        public ServiceResponse<bool> DeleteUser(int userId);

        
    }
}