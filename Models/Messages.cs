using System.ComponentModel.DataAnnotations;

namespace OnlineChat.Models
{
    public class Messages
    {
        [Key]
        public int MessageID { get; set; }

        [Required]
        public int SenderID { get; set; }

        [Required]
        public int ReceiverID { get; set; }

        [Required]
        public string EncryptedContent { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }
    }
}
