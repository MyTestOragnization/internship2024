using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlbumsController : Controller
    {
        public IActionResult AlbumList()
        {
            SongRepository songRepository = new SongRepository();
            var albums = songRepository.GetAlbums();

            return View(albums);
        }
    }
}
