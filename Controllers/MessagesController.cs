using Microsoft.AspNetCore.Mvc;
using OnlineChat.Services;
using OnlineChat.Models;
namespace OnlineChat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService messageService;

        public MessagesController(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        [HttpPost("send")]
        public IActionResult Send([FromBody] IMessageService message) 
        {
            return Ok(message);
        }

    }
}
