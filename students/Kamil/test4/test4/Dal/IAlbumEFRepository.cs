using test4.Models;

namespace test4.Dal
{
    public interface IAlbumEFRepository
    {
        public void EditAlbum(Album a);
        public Album GetAlbum(int Id);
        public IEnumerable<Album> GetAlbumy();
        public void DeleteAlbum(int Id);
        public void AddAlbum(Album a);
        public IEnumerable<AlbumNice> GetAlbumyNice();
    }
}
