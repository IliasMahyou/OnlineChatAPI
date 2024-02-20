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
        public IActionResult Authenticate(UsersDto userService)
        {
            return Ok(userService);
        }
    }
}
