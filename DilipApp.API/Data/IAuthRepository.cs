using System.Threading.Tasks;
using DilipApp.API.Models;

namespace DilipApp.API.Data
{
    public interface IAuthRepository
    {
          Task<User> Register(User user,string password);
        Task<User> Login(string username,string passowrd);
        Task<bool> UserExists(string username);
    }
}