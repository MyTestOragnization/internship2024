using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace test1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Profile()
        {
       
            SongRepository songRepository = new SongRepository();
            var piosenki = songRepository.GetAllSongs();

            return View(piosenki);
        }
        public IActionResult Edit(int SongID)
        {
            TestPiosenka testPiosenka;
            SongRepository songRepository = new SongRepository();
                
            testPiosenka= songRepository.GetSongById(SongID);

            return View(testPiosenka);
        }
        public IActionResult EditSong(int SongID, TestPiosenka testPiosenka)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    SongRepository songRepository = new SongRepository();
                    if (songRepository.EditSong(SongID, testPiosenka))
                    {
                        return RedirectToAction("Index");
                    }
                    return View();
                }
            
            }
            catch (Exception ex)
            {
                return View();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
