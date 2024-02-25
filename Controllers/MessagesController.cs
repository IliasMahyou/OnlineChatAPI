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
        public async Task<IActionResult> Send([FromBody] Messages message) 
        {
            var newMessage = await  messageService.SendMessageAsync(message.SenderID,message.ReceiverID,message.EncryptedContent);
            if(newMessage.SenderID != null && newMessage.EncryptedContent != null && newMessage.ReceiverID != null)
            {
                return Ok(newMessage);
            }    
            return BadRequest();
        }

    }
}
