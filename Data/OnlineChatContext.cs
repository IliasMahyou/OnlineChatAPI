using Microsoft.EntityFrameworkCore;
using OnlineChat.Models;
namespace OnlineChat.Data
{
    public class OnlineChatContext : DbContext
    {
        public OnlineChatContext(DbContextOptions<OnlineChatContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Messages> Messages { get; set; }

    }
}
