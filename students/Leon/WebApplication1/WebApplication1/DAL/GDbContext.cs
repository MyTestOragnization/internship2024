using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1.Dal
{
    public class GDbContext : DbContext
    {
        public DbSet<Game> Game { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<RelGTD> GameToDeveloper { get; set; }
        public DbSet<RelGTP> GameToPublisher { get; set; }


        public GDbContext(DbContextOptions<GDbContext> options) : base(options)
        {
        }




    }
}
