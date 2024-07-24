using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test4.Dal;
using test4.Models;

namespace test4.Controllers.api
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public MyDbContext DbContext { get; set; }
        public IAlbumEFRepository AlbumEFRepository { get; set; }
        public ISaleEFRepository SaleEFRepository { get; set; }
        private readonly ILogger<HomeController> _logger;

        public UserController(ILogger<HomeController> logger, MyDbContext dbContext, IAlbumEFRepository albumRepository, ISaleEFRepository saleEFRepository)
        {
            _logger = logger;
            DbContext = dbContext;
            AlbumEFRepository = albumRepository;
            SaleEFRepository = saleEFRepository;
        }
       //  GET: api/<UserController>
        [HttpGet]
        public string Get()
        {
          //  List<Users> list;//usersRepository.GetUsers();
            return "list";

        }
      //  GET api/<UserController>/5
        [HttpGet("{id}")]
        public IEnumerable<Album> Get(int id)
        {
            IEnumerable<Album> list = AlbumEFRepository.GetAlbumy();
            return list;

        }

       //  POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

       //  PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

      //   DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
