using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Data
{
    public class ConnectRepository : IConnectRepository
    {
        private readonly DbContextClass dbContext;

        public ConnectRepository(DbContextClass dbContext)
        {
            dbContext = dbContext;
        }

        public IEnumerable<ArtistAlbumSong> GetAll()
        {
            var result = (from al in dbContext.Albums
                join con in dbContext.ConnectDb on al.AlbumID equals con.AlbumId
                join s in dbContext.Songs on con.SongId equals s.SongID
                join ar in dbContext.Artist on con.ArtistId equals ar.Id
                select new ArtistAlbumSong { AlbumTitle = al.AlbumTitle, ArtistName = ar.Name, SongTitle = s.SongTitle}).ToList();

            return result;
        }
    }
}
// SELECT AlbumTitle, AlbumID, SongTitle, SongID, ArtistName, ArtistID FROM dbo.Albums JOIN dbo.ConnectDB ON dbo.Albums.AlbumID=dbo.ConnectDB.IDalbum JOIN dbo.Songs ON 
// dbo.Songs.SongID=dbo.ConnectDB.IDsong JOIN dbo.Artists ON dbo.Artists.ArtistID=dbo.ConnectDB.IDartist