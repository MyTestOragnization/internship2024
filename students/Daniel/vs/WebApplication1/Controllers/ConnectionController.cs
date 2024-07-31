using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionController : Controller
    {
        public DbContextClass DbContext { get; }
        public IConnectRepository Repository { get; }
        public ConnectionController(DbContextClass dbContext, IConnectRepository repository)
        {
            DbContext = dbContext;
            Repository = repository;
        }
        [HttpGet("GetAll")]
        public IEnumerable<ConnectDBtable> GetAll()
        {
            return Repository.GetAll();
        }
    }
}
