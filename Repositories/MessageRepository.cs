using OnlineChat.Models;

namespace OnlineChat.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        public Task CreateMessageAsync(Messages message)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Messages>> GetMessagesForUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Messages> GetMesssageByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
