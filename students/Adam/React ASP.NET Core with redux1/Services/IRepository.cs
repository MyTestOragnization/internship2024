using React_ASP.NET_Core_with_redux1.Models;

namespace React_ASP.NET_Core_with_redux1.Services
{
    public interface IRepository
    {
        public User Auth(LoginModel login);
        public void Register(LoginModel login);
        public User Get(string email);
    }
}
