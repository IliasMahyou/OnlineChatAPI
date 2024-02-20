using OnlineChat.Models;
namespace OnlineChat.Repositories
{
    public interface IUserRepository
    {
        Task<Users>GetUserById(int id);
        Task<Users> GetUserByName(string name);
        Task<IEnumerable<Users>>GetAllUsers();
        Task CreateUserAsync(Users user);
    }
}
