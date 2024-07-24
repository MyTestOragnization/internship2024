using Microsoft.EntityFrameworkCore;
using test4.Models;

namespace test4.Dal
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        
        public DbSet<Album> Album { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<SaleNice> SaleNice { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<AlbumNice> AlbumNice { get; set; }
        public DbSet<MTMAlbumAuthor> MTMAlbumAuthor { get; set; }
        //  protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //          modelBuilder.Entity<Album>().ToTable("Album");
        //        }
    }
}
