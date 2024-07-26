using WebApplication1.Models;
using WebApplication1.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Data.SqlClient;
using System.Collections;
namespace WebApplication1.Dal
{
    public class GameRepository : IGameRepository
    {
        private GDbContext dbContext;
        public GameRepository(GDbContext context)
        {
            dbContext = context;
        }

        /*        public Game SearchGame(string Name)
                {
                    throw new NotImplementedException();
                }*/

        public IEnumerable<Game> Game()
        {
            IEnumerable<Game> g;
            try
            {
                g = dbContext.Game.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return g;

        }

        public void AddGame(Game game)
        {
            try
            {
                game.Id = 0;
                dbContext.Game.Add(game);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public void DeleteGame(int Id)
        {
            try
            {
                Game g = dbContext.Game.Single(x => x.Id == Id);
                dbContext.Game.Remove(g);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public Game GetGame(int Id)
        {

            Game g;
            try
            {

                g = dbContext.Game.Single(b => b.Id == Id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return g;

        }
        public void EditGame(Game game)
        {
            {
                try
                {
                    //                using (var context = new MyDbContext())
                    //                {

                    dbContext.Game.Update(game);
                    dbContext.SaveChanges();
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //    var p = context.Albumy.FirstOrDefault(p=> p.Price <100m);
            }
        }
    }
}
