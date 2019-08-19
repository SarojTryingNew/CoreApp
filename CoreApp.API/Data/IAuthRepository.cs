using System.Threading.Tasks;
using CoreApp.API.Models;

namespace CoreApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string userName,string password);
        Task<bool> UserExists(string userName);
    }
}