using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test4.Dal;
using test4.Models;

 

namespace test4.Controllers
{
    public class HomeController : Controller
    {
        private AlbumRepository AlbumRepository = new AlbumRepository();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Albumy()
        {
            var list = AlbumRepository.GetAlbumy();
            
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
