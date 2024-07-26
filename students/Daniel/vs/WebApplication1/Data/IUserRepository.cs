

using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Data
{
    public interface IUserRepository
    {
        User GetOneUser(string id);
        bool Register(RegisterDTO user);
        bool Login(LoginDTO loginDTO);
    }
}
