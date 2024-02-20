using OnlineChat.Models;

namespace OnlineChat.Repositories
{
    public class UserRepository : IUserRepository
    {
        
        public Task CreateUserAsync(Users user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Users>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUserByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
