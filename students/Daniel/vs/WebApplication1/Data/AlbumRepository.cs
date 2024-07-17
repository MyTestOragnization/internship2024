using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Metadata;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AlbumRepository : IAlbumRepository
    {
        public AlbumRepository(DbContextClass dbContext)
        {
            DbContext = dbContext;
        }
        public AlbumRepository() { }
        public DbContextClass DbContext;

        public IEnumerable<Albums> GetAlbums()
        {
            IEnumerable<Albums> albums = DbContext.Albums.ToList();
            return albums;
        }

        public Albums GetOneAlbum(int id)
        {
            string sql = "SELECT * FROM Albums WHERE AlbumID="+id+";";
            var album = DbContext.Albums.Find(id);
            return album;
        }

        public bool SaveEdited(Albums album)
        {
            var result = DbContext.Update(album);
            DbContext.SaveChanges();
            return result != null;
        }
    }
}
