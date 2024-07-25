using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface IAlbumRepository
    {
        public IEnumerable<Album> GetAlbums();
        public Album GetOneAlbum(int id);
        public bool EditAlbum(int id,Album album);
        public bool AddNewAlbum (Album album);
        public bool DeleteAlbum (int id);
    }
}
