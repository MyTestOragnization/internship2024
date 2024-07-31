using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Data
{
    public class ConnectRepository : IConnectRepository
    {
        

        public ConnectRepository(DbContextClass dbContext)
        {
            dbContext = dbContext;
        }
        public DbContextClass dbContext { get; }
        
        public IEnumerable<ConnectDBtable> GetAll()
        {
            return dbContext.ConnectDb.Include(e=>e.albums).Include(e=>e.song).Include(e=>e.artist).ToList();
        }
    }
}
//SELECT AlbumTitle, AlbumID, SongTitle, SongID, ArtistName, ArtistID FROM dbo.Albums JOIN dbo.ConnectDB ON dbo.Albums.AlbumID=dbo.ConnectDB.IDalbum JOIN dbo.Songs ON 
//dbo.Songs.SongID=dbo.ConnectDB.IDsong JOIN dbo.Artists ON dbo.Artists.ArtistID=dbo.ConnectDB.IDartist