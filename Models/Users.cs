using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace OnlineChat.Models
{
    public class Users
    {
        [Key] 
        public int UserId { get; set; }

        [Required,NotNull] 
        [MaxLength(50)]
        public string Username { get; set; }

        [Required,NotNull]
        public string PasswordHash { get; set; }

        [Required]
        [EmailAddress,NotNull]
        public string EmailAddress { get; set; }

        [Required, NotNull]
        public string imageURL { get; set; }
        
    }
}
