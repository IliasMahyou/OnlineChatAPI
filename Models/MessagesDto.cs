using System.ComponentModel.DataAnnotations;

namespace OnlineChat.Models
{
    public class MessagesDto
    {
       
        public int MessageID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string EncryptedContent { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
