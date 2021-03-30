using FlexOffice.Api.Dto;
using FlexOffice.Api.Serialization;
//using FlexOffice.Data.Models;
using FlexOffice.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FlexOffice.Api.Controllers 
{  
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly ILogger<IUserService> _logger;
        private readonly IUserService _userService;

        public AppUserController(IUserService userService, ILogger<IUserService> logger)
        {
            _logger = logger;
            _userService = userService; 
        }

        [HttpGet("api/user")]
        public ActionResult GetUsers()
        {
            _logger.LogInformation("Get users list.");
            var users = _userService.GetAllUsers();
            var usersMapper = UserMapper.SerializeUsersModel(users);
            return Ok(usersMapper);
        }

        [HttpGet("api/user/{id}")]
        public ActionResult GetUser (int id)
        {
            _logger.LogInformation("Get user by id");
            var user = _userService.GetUserById(id);
            var userMapper = UserMapper.SerializeUserModel(user);
            return Ok(userMapper);
        }
        
        // ToDo : Rozwazyc zastosowanie Dto
        [HttpPost("api/user")]
        public ActionResult CreateUser([FromBody] UserCreateDTO user)
        {
            _logger.LogInformation("Add user.");
            var userMapper = UserMapper.SerializeCreateUser(user);
            var response = _userService.AddUser(userMapper);
            return Ok(response);
        }

        // ToDo : Rozwazyc zastosowanie Dto
        [HttpDelete("api/user/{id}")]
        public ActionResult DeleteUser(int id)
        {
            _logger.LogInformation("Delete user.");
            var response = _userService.DeleteUser(id);
            return Ok(response);
        }
        
    }
}