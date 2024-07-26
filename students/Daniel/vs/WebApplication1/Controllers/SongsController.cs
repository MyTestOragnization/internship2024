using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : Controller
    {
        public SongsController(DbContextClass dbContextClass, ISongRepository repository)
        {
            DbContext = dbContextClass;
            SongRepository = repository;
        }

        private DbContextClass DbContext { get; }
        public ISongRepository SongRepository { get; }


        [HttpGet("GetSong")]
        public IEnumerable<Song> GetAllSongs()
        {
            return SongRepository.GetAllSongs();
        }

        [HttpGet("GetSong/{id}")]
        public Song GetOneSong(int id) 
        {
            return SongRepository.GetOneSong(id);
        }

        [HttpPost("AddSong")]
        public bool AddNewSong(Song song) 
        { 
            return SongRepository.AddNewSong(song);
        }

        [HttpPut("EditSong/{id}")]
        public bool UpdateSong(int id, Song song) 
        { 
            return SongRepository.EditSong(id, song);
        }

        [HttpDelete("DeleteSong/{id}")]
        public bool DeleteSong(int id) 
        {
            return SongRepository.DeleteSong(id);
        }
    }
}
