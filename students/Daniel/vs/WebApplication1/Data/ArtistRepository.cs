using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ArtistRepository : IArtistRepository
    {
        public ArtistRepository(DbContextClass dbContextClass)
        {
            DbContextClass = dbContextClass;
        }

        public DbContextClass DbContextClass { get; }

        public IEnumerable<Artist> GetAllArtists()
        {
            var result = DbContextClass.Artist.ToArray();
            return result;
        }
    }
}
