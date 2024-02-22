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
        public async Task<IActionResult> Register([FromBody] RegisterUser registerUser)
        {
            bool success = await _userService.RegisterUserAync(registerUser.Username, registerUser.Password, registerUser.Email);
            if (success)
            {
                return Ok(new { message = "Successful registration" });
            }
            else
            {
                return BadRequest(new { message = "Registration failed" });
            }
        }




        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest loginRequest)
        {
            var user = await _userService.AuthenticateUsersAsync(loginRequest.Username, loginRequest.Password);

            if (user != null)
            {
                return Ok(new { message = "Authentication successful", user });
            }
            else
            {               
                return Unauthorized(new { message = "Username or password is incorrect" });
            }
        }
    }
}
