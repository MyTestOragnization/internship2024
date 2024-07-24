using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test1.Dal;
using Test1.Models;


namespace Test1.Controllers
{

    public class HomeController : Controller
    {
        private CompanyRepository CompanyRepository = new CompanyRepository();
        private GameRepository GameRepository = new GameRepository();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Companies()
        {
            var list = CompanyRepository.GetCompanies();

            return View(list);
        }

        public IActionResult Games()
        {
            var list = GameRepository.GetGames();

            return View(list);
        }


        public IActionResult GameDeveloper(int gameId)
        {
           
            var list = new GameToDevRepository().GetGameDevs(gameId);

            return View(list);
        }


        public IActionResult GamePublisher(int gameId)
        {

            var list = new GameToPubRepository().GetGamePubs(gameId);

            return View(list);
        }



        public IActionResult Developed(int companyId)
        {

            var list = new CompanyToDevRepository().GetDeveloped(companyId);

            if (list.Count == 0)
                return RedirectToAction("BD");

            return View(list);
        }



        public IActionResult Published(int companyId)
        {

            var list = new CompanyToPubRepository().GetPublished(companyId);

            if (list.Count == 0)
                return RedirectToAction("BD");

            return View(list);
        }


        public IActionResult BD()
        {
            return View();
        }


        public IActionResult SearchGames(string GName)
        {
            var list = new SGRepository().GetSGames(GName);

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
