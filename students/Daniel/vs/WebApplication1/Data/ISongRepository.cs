using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface ISongRepository
    {
        IEnumerable<Song> GetAllSongs();
        Song GetOneSong(int id);
        bool AddNewSong(Song song);
        bool EditSong(int id, Song song);
        bool DeleteSong(int id);

    }
}
