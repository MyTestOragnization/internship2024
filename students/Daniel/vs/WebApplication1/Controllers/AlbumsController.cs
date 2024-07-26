using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : Controller
    {
        public AlbumsController(DbContextClass dbContext, IAlbumRepository albumRepository) 
        {
            DbContext = dbContext;
            AlbumRepository = albumRepository;
        }

        public DbContextClass DbContext { get; }
        public IAlbumRepository AlbumRepository { get; }

        [HttpGet("GetAlbums")]
        public IEnumerable<Album> GetAllAlbums()
        {
           return AlbumRepository.GetAlbums();
        }

        [HttpGet("GetAlbums/{id}")]
        public Album GetOneAlbum(int id)
        {
            return AlbumRepository.GetOneAlbum(id);
        }

        [HttpPut("EditArtist/{id}")]
        public bool EditArtist(int id, Album albums)
        {
            return AlbumRepository.EditAlbum(id, albums);
        }

        [HttpPost("AddNewAlbum")]
        public bool AddNewAlbum(Album albums) 
        {
           return AlbumRepository.AddNewAlbum(albums);
        }

        [HttpDelete("DeleteAlbum/{id}")]
        public bool DeleteAlbum(int id) 
        {
            return AlbumRepository.DeleteAlbum(id);
        }
       
    }
}
