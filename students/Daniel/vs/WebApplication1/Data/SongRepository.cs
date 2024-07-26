using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class SongRepository : ISongRepository
    {

        public SongRepository(DbContextClass dbContextClass)
        {
            DbContext = dbContextClass;
        }
        public DbContextClass DbContext { get; }


        public IEnumerable<Song> GetAllSongs()
        {
            return DbContext.Songs.ToList();
        }
        public Song GetOneSong(int id)
        {
            return DbContext.Songs.Find(id);
        }
        public bool AddNewSong(Song song)
        {
            if (song.SongID == 0)
            {
                var result = DbContext.Add(song);
                if (result != null)
                {
                    DbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteSong(int id)
        {
            var song = GetOneSong(id);
            if (song != null)
            {
                if (DbContext.Remove(song) != null)
                {
                    DbContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool EditSong(int id, Song song)
        {
            if (song.SongID != id)
            {
                return false;
            }

            if (DbContext.Update(song) != null)
            {
                DbContext.SaveChanges();
                return true;
            }
            return false;
        }


    }
}
