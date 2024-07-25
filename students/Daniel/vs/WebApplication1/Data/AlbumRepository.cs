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

        private bool disposedValue;
        public DbContextClass DbContext { get; }

        public IEnumerable<Album> GetAlbums()
        {
            IEnumerable<Album> albums = DbContext.Albums.ToList();
            return albums;
        }

        public Album GetOneAlbum(int id)
        {
            var album = DbContext.Albums.Find(id);
            return album;
        }

        public bool EditAlbum (int id, Album albums)
        {
            if (albums.AlbumID != id)
            {
                return false;
            }
            if (DbContext.Albums.Update(albums)!= null)
            {
                DbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool AddNewAlbum(Album album)
        {
            var result = DbContext.Albums.Add(album);
            DbContext.SaveChanges();
            return result != null;
        }

        public bool DeleteAlbum(int id)
        {
            var album = GetOneAlbum(id);
            if (album != null)
            {
                if (DbContext.Albums.Remove(album) != null)
                {
                    DbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        
    }
}
