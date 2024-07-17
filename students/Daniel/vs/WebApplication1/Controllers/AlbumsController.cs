using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlbumsController : Controller
    {
        public AlbumsController(DbContextClass dbContext, IAlbumRepository albumRepository) 
        {
            DbContext = dbContext;
            AlbumRepository = albumRepository;
        }

        public DbContextClass DbContext { get; }
        public IAlbumRepository AlbumRepository { get; }

        [HttpGet]
        public IActionResult AlbumList()
        {
           var albums = AlbumRepository.GetAlbums();

            return View(albums);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var album = AlbumRepository.GetOneAlbum(id);
            return View(album);
        }

        [HttpPost]
        public IActionResult SaveEdited(Albums album) 
        {
            var result = AlbumRepository.SaveEdited(album);
            if (result == true) 
            {
                return RedirectToAction("AlbumList");
            }
            else { return View(); }
        }
        [HttpGet]
        public IActionResult AddView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewAlbum(Albums album)
        {
            var result = AlbumRepository.AddNewAlbum(album);
            if (result == true) 
            {
                return RedirectToAction("AlbumList");
            }
            else { return View(); }
        }
        public IActionResult Delete(int id) 
        {
            var result = AlbumRepository.DeleteAlbum(id);

            if (result == true) 
            {
                return RedirectToAction("AlbumList");
            }
            else { return View(); }
        }
    }
}
