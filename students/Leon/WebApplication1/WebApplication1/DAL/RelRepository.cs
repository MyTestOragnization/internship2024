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








    }
}
