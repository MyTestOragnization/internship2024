using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface RepoInterface
    {
        List<Albums> GetAlbums { get; }

    }
}
