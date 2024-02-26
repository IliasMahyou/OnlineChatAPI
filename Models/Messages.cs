using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace OnlineChat.Models
{
    public class Messages
    {
        [Key, NotNull]
        public int MessageID { get; set; }

        [Required,NotNull]
        public int SenderID { get; set; }

        [Required,NotNull]
        public int ReceiverID { get; set; }

        [Required,NotNull]
        public string EncryptedContent { get; set; }

        [Required,NotNull]
        public DateTime TimeStamp { get; set; }
    }
}
