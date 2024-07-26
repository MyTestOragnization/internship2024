using WebApplication1.Models;
using WebApplication1.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Data.SqlClient;
using System.Collections;

namespace WebApplication1.Dal
{
    public class RelRepository : IRelRepository
    {
        private GDbContext dbContext;
        public RelRepository(GDbContext context)
        {
            dbContext = context;
        }




        public void AddRelGTD(RelGTD gtd)
                {
                    try
                    {
                        gtd.Id = 0;
                        dbContext.GameToDeveloper.Add(gtd);
                        dbContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw ex;
                    }
                }
        public void AddRelGTP(RelGTP gtp)
        {
            try
            {
                gtp.Id = 0;
                dbContext.GameToPublisher.Add(gtp);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
















    }
}
