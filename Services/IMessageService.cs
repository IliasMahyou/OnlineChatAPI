using OnlineChat.Models;
namespace OnlineChat.Services
{
    public interface IMessageService
    {
        Task<Messages> SendMessageAsync(int senderID, int receiverID, string content);
        Task<IEnumerable<Messages>> GetMessagesForUserAsync(int userID);
    }
}
