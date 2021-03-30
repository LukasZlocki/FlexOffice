using FlexOffice.Data.Models;
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
            return Ok(users);
        }

        [HttpGet("api/user/{id}")]
        public ActionResult GetUser (int id)
        {
            _logger.LogInformation("Get user by id");
            var user = _userService.GetUserById(id);
            return Ok(user);
        }
        
        // ToDo : Zastosowac Dto
        [HttpPost("api/user")]
        public ActionResult CreateUser([FromBody] AppUser user)
        {
            _logger.LogInformation("Add user.");
            var response = _userService.AddUser(user);
            return Ok(response);
        }

        [HttpDelete("api/user/{id}")]
        public ActionResult DeleteUser(int id)
        {
            _logger.LogInformation("Delete user.");
            var response = _userService.DeleteUser(id);
            return Ok(response);
        }
        
    }
}