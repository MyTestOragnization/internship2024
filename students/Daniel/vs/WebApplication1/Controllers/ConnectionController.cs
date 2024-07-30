using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionController : ControllerBase
    {
        public DbContext DbContext { get; }
        public IConnectRepository Repository { get; }
        public ConnectionController(DbContext dbContext, IConnectRepository repository)
        {
            DbContext = dbContext;
            Repository = repository;
        }
        [HttpGet("GetAll")]
        public object GetAll()
        {
            return Repository.GetAll();
        }
    }
}
