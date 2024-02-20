using OnlineChat.Models;
namespace OnlineChat.Repositories
{
    public interface IMessageRepository
    {
        Task<Messages>GetMesssageByIdAsync(int id);
        Task<IEnumerable<Messages>>GetMessagesForUserAsync(int userId);
        Task CreateMessageAsync(Messages message);
    }
}
