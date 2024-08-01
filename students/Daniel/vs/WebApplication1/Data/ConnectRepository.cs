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
        
        public IEnumerable<ArtistAlbumSong> GetAll()
        {
            var query = (from con in dbContext.ConnectDb.ToList()
                join al in dbContext.Albums.ToList() on con.IDalbum equals al.AlbumID
                         join sng in dbContext.Songs.ToList() on con.IDsong equals sng.SongID
                join art in dbContext.Artist.ToList() on con.IDartist equals art.Id
                select new ArtistAlbumSong()
                {
                    AlbumTitle = al.AlbumTitle,
                    AlbumID = al.AlbumID,
                    SongTitle = sng.SongTitle,
                    SongID = sng.SongID,
                    ArtistName = art.Name,
                    ArtistID = art.Id
                });
            
            return query;
        }
    }
}
//SELECT AlbumTitle, AlbumID, SongTitle, SongID, ArtistName, ArtistID FROM dbo.Albums JOIN dbo.ConnectDB ON dbo.Albums.AlbumID=dbo.ConnectDB.IDalbum JOIN dbo.Songs ON 
//dbo.Songs.SongID=dbo.ConnectDB.IDsong JOIN dbo.Artists ON dbo.Artists.ArtistID=dbo.ConnectDB.IDartist