using System;
using System.Collections.Generic;
using System.Linq;
using FlexOffice.Data;
using FlexOffice.Data.Models;

namespace FlexOffice.Services
{
    public class UserService : IUserService
    {
        private readonly OfficeDbContext _db;

        public UserService(OfficeDbContext db)
        {
            _db = db;
        }

        // CREATE
        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>ServiceResponse<AppUser></returns>
        public ServiceResponse<AppUser> AddUser(AppUser user)
        {
            try
            {
                _db.AppUsers.Add(user);
                _db.SaveChanges();
                return new ServiceResponse<AppUser> 
                {
                    IsSucess = true,
                    Message = "User added.",
                    Time = DateTime.UtcNow,
                    Data = user
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<AppUser> 
                {
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = user
                };
            }
        }

        // READ
        /// <summary>
        /// Get all users from db
        /// </summary>
        /// <returns>List<AppUsers></returns>
        public List<AppUser> GetAllUsers()
        {
            var service = _db.AppUsers.ToList();
            return service;
        }

        // READ
        /// <summary>
        /// Get user by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns><AppUser></returns>
        public AppUser GetUserById(int id)
        {
            var service = _db.AppUsers.Find(id);
            return service;
        }

        /*
        // UPDATE
        public ServiceResponse<bool> UpdateUser(int userId)
        {
            throw new System.NotImplementedException();
        }
        */

        // DELETE
        /// <summary>
        /// Delete user by primary key
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>ServiceResponse<bool></returns>
        public ServiceResponse<bool> DeleteUser(int userId)
        {
            var user = _db.AppUsers.Find(userId);
            if (user == null)
            {
                return new ServiceResponse<bool> 
                {
                    IsSucess = false,
                    Message = "Not able to find user.",
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }
            try
            {
                _db.AppUsers.Remove(user);
                _db.SaveChanges();
                return new ServiceResponse<bool> 
                {
                    IsSucess = true,
                    Message = "User removed.",
                    Time = DateTime.UtcNow,
                    Data = true
                };

            }
            catch (Exception e)
            {
                return new ServiceResponse<bool> 
                {
                    IsSucess = false,
                    Message = e.StackTrace,
                    Time = DateTime.UtcNow,
                    Data = false
                };
            }
        }


    }
}