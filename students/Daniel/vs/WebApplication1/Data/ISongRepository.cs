using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface ISongRepository
    {
        public List<Piosenka> GetAllSongs();
        public bool EditSong(int Id, Piosenka song);
        public Piosenka GetSongById(int SongID);
        public bool DeleteSong(int SongID);
        public bool AddNewSong(Piosenka piosenka);
    }
}
