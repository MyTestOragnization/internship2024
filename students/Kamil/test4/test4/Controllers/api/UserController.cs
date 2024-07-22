using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test4.Dal;
using test4.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test4.Controllers.api
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public MyDbContext DbContext { get; set; }
        //        private AlbumEntity AlbumEntityRepository = new AlbumEntity();
        public IAlbumEFRepository AlbumEFRepository { get; set; }
        public ISaleEFRepository SaleEFRepository { get; set; }
        //private SaleRepository saleRepository = new SaleRepository();
        private UsersRepository usersRepository = new UsersRepository();
        private AlbumRepository albumRepository = new AlbumRepository();
        private readonly ILogger<HomeController> _logger;

        public UserController(ILogger<HomeController> logger, MyDbContext dbContext, IAlbumEFRepository albumRepository, ISaleEFRepository saleEFRepository)
        {
            _logger = logger;
            DbContext = dbContext;
            AlbumEFRepository = albumRepository;
            SaleEFRepository = saleEFRepository;
        }
        // GET: api/<UserController>
        [HttpGet]
        public List<Users> Get()
        {
            List<Users> list = usersRepository.GetUsers();
            return list;
            
        }
//        




        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public List<Users> Get(int id)
        {
            List<Users> list = usersRepository.GetUsers();
            return list;
            
        }

        // POST api/<UserController>
        [HttpPost]
        public List<Users> Post([FromBody] string value)
        {
            List<Users> list = usersRepository.GetUsers();
            return list;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
