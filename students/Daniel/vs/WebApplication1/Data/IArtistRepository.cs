using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetAllArtists();
    }
}
