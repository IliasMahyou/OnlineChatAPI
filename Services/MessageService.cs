using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineChat.Data;
using OnlineChat.Models;

namespace OnlineChat.Services
{
    public class MessageService : IMessageService
    {
        private readonly OnlineChatContext _context;
        public async Task<IEnumerable<Messages>> GetMessagesForUserAsync(int userID)
        {
          
                var messages = await _context.Messages
                                              .Where(m => m.ReceiverID == userID)
                                              .ToListAsync();
                return messages;
            
        }

        public async Task<Messages> SendMessageAsync(int senderID, int receiverID, string encryptedContent)
        {
            var message = new Messages
            {
                SenderID = senderID,
                ReceiverID = receiverID,
                EncryptedContent = encryptedContent,
                TimeStamp = DateTime.UtcNow 
            };

            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
            return message;
        }

    }
}
