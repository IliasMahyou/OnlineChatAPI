using OnlineChat.Models;
using System.Collections.Generic;

public class MockData
{
    public static List<Users> GetMockUsers()
    {
        return new List<Users>
        {
            new Users { UserId = 1, UserName = "AliceSmith", EmailAddress = "alice@example.com" },
            new Users { UserId = 2, UserName = "BobJones", EmailAddress = "bob@example.com" },
            new Users { UserId = 3, UserName = "CharlieBrown", EmailAddress = "charlie@example.com" },
            
        };
    }
    public static List<Messages> GetMockMessages()
    {
        return new List<Messages>
        {
            new Messages { MessageID = 1, SenderID = 1, ReceiverID = 2, EncryptedContent = "EncryptedText1", TimeStamp = DateTime.Now.AddMinutes(-5) },
            new Messages { MessageID = 2, SenderID = 2, ReceiverID = 1, EncryptedContent = "EncryptedText2", TimeStamp = DateTime.Now.AddMinutes(-4) },
            new Messages { MessageID = 3, SenderID = 1, ReceiverID = 3, EncryptedContent = "EncryptedText3", TimeStamp = DateTime.Now.AddMinutes(-3) },
            
        };
    }
}
