using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.MSIdentity.Shared;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ArtistRepository : IArtistRepository
    {
        public ArtistRepository(DbContextClass dbContextClass)
        {
            DbContext = dbContextClass;
        }

        public DbContextClass DbContext { get; }

        public IEnumerable<Artist> GetAllArtists()
        {
            var result = DbContext.Artist.ToList();
            return result;
        }

        public Artist GetOneArtist(int id)
        {
            var result = DbContext.Artist.Find(id);
            return result;
        }

        public bool AddNewArtist(Artist artist)
        {
            if (artist.Id == 0)
            {
                var result = DbContext.Artist.Add(artist);
                if (result != null)
                {
                    DbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteArtist(int id)
        {
            var artist = GetOneArtist(id);
            if (artist != null) 
            {
                if (DbContext.Artist.Remove(artist) != null)
                {
                    DbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool EditArtist(int id, Artist artist)
        {
            if(artist.Id != id)
            {
                return false; 
            }

            if (DbContext.Artist.Update(artist) != null)
            {
                DbContext.SaveChanges();
                    return true;
            }
            return false;
        }
    }
}
