using System.ComponentModel.DataAnnotations;

namespace OnlineChat.Models
{
    public class UsersDto
    {
        [MaxLength(50)]
        public string UserName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
