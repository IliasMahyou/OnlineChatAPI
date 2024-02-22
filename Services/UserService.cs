using Microsoft.EntityFrameworkCore;
using OnlineChat.Data;
using OnlineChat.Models;
using Org.BouncyCastle.Crypto.Generators;

namespace OnlineChat.Services
{
    public class UserService : IUserService
    {
        private readonly OnlineChatContext _context;

        public UserService(OnlineChatContext context)
        {
            _context = context;
        }

        public async Task<Users> AuthenticateUsersAsync(string username, string password)
        {
            var user = await _context.Users
                                     .FirstOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());

            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                
                return user;
            }
            else
            {
                
                return null;
            }
        }

        public async Task<bool> RegisterUserAync(string username, string password, string email)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            Users user = new Users
            {
                Username = username,
                PasswordHash = passwordHash,
                EmailAddress = email
            };
            _context.Users.Add(user);

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }catch
            {
                return false;
            }
            


        }
    }
}
