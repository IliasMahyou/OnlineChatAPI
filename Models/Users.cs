using System.ComponentModel.DataAnnotations;

namespace OnlineChat.Models
{
    public class Users
    {
        [Key] 
        public int UserId { get; set; }

        [Required] 
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        
        
    }
}
