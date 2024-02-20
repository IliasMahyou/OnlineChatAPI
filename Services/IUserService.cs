using OnlineChat.Models;
using OnlineChat.Services;
using System.Threading.Tasks;
namespace OnlineChat.Services
{
    public interface IUserService
    {
        Task<Users>AuthenticateUsersAsync(string username, string password);
        Task RegisterUserAync(string username, string password, string email);
    }
}
