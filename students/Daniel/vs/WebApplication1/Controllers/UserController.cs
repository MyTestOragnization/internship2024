using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;
using WebApplication1.TokenFolder;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public UserController(DbContextClass dbContextClass, IUserRepository userRepository, JwtConfig jwtConfig)
        {
            DbContext = dbContextClass;
            UserRepository = userRepository;
            this.jwtConfig = jwtConfig;
        }
        private readonly JwtConfig jwtConfig;

        public DbContextClass DbContext { get; }
        public IUserRepository UserRepository { get; }

        [HttpGet("GetUser/{id}")]
        public User GetOneUser(string username) 
        {
            return UserRepository.GetOneUser(username);
        }

        [HttpPost("RegisterUser")]
        public IActionResult Register([FromBody] User user)  
        {
            if (UserRepository.Register(user))
            {
                return Ok("User registered succesfully");
            }
            return BadRequest();
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDTO loginDTO)
        {

            if (UserRepository.Login(loginDTO))
            {
                var jwt = jwtConfig.GenerateKey(loginDTO.username);
                string success = "Login success";
                return Ok(new { jwt, success});
            }
            return BadRequest();
        }
    }
}
