
using WebApplication1.Models;
namespace WebApplication1.Dal
{
    public interface IGameRepository
    {
        public Game GetGame(int Id);
        public Game GetGameId(string name);
        public IEnumerable<Game> Game();
        public void AddGame(Game game);
        public void DeleteGame(int Id);
        public void EditGame(Game game);
    }
}
