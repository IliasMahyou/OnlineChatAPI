using Microsoft.AspNetCore.Mvc;
using OnlineChat.Models;
using OnlineChat.Services;

namespace OnlineChat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpPost("register")]
        public IActionResult Register(IUserService userService)
        {
            return Ok(userService);
        }


        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest loginRequest)
        {
            var user = await _userService.AuthenticateUsersAsync(loginRequest.UserName, loginRequest.Password);

            if (user != null)
            {
                // Authentication successful
                // Generate a JWT token or any other form of token if necessary
                // and return the appropriate data and status code
                return Ok(new { message = "Authentication successful", user });
            }
            else
            {
                // Authentication failed
                return Unauthorized(new { message = "Username or password is incorrect" });
            }
        }
    }
}
