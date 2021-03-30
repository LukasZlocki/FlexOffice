using System.Collections.Generic;
using System.Linq;
using FlexOffice.Api.Dto;
using FlexOffice.Data.Models;

namespace FlexOffice.Api.Serialization
{
    public class UserMapper
    {
        
        /// <summary>
        /// Maps AppUser data model to UserDTO data model 
        /// </summary>
        /// <param name="user"></param>
        /// <returns><UserDTO></returns>
        public static UserReadDTO SerializeUserModel(AppUser user)
        {
            return new UserReadDTO
            {   
                Id = user.Id,
                UserLog = user.UserLog,
                Email = user.Email
            };
        }

        /// <summary>
        /// Maps UserDTO data model to AppUser data model
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        public static AppUser SerializeUserModel(UserReadDTO userDTO)
        {
            return new AppUser
            {
                Id = userDTO.Id,
                UserLog = userDTO.UserLog,
                Email = userDTO.Email
            };
        }

        public static List<UserReadDTO> SerializeUsersModel (IEnumerable<AppUser> users)
        {
            return users.Select( user => new UserReadDTO
            {
                 Id = user.Id,
                UserLog = user.UserLog,
                Email = user.Email
            }).ToList();
        }

        public static AppUser SerializeCreateUser (UserCreateDTO userCreateDto)
        {
            return new AppUser
            {
                UserLog = userCreateDto.UserLog,
                Password = userCreateDto.Password,
                Email = userCreateDto.Email
            };
        }

    }
}