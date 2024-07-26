using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Dal;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class HomeController : Controller
    {
        public GDbContext DbContext { get; set; }

        public IGameRepository GameRepository { get; set; }
        public ICompanyRepository CompanyRepository { get; set; }
        public IRelRepository RelRepository { get; set; }
        public HomeController(GDbContext dbContext, IGameRepository gameRepository, ICompanyRepository companyRepository, IRelRepository relRepository, ILogger<HomeController> logger)
        {
            DbContext = dbContext;
            GameRepository = gameRepository;
            CompanyRepository = companyRepository;
            RelRepository = relRepository;
            _logger = logger;
        }

        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Games()
        {
            var Gry = GameRepository.Game();
            return View(Gry);
        }

        public IActionResult AddGame()
        {
            return View(); 
        }
        public IActionResult AddingGame(Game g)
        {
            GameRepository.AddGame(g);
            return RedirectToAction("Games");
        }
        public IActionResult DeleteGame(int Id)
        {
            GameRepository.DeleteGame(Id);
            return RedirectToAction("Games");
        }
        public IActionResult EditGame(int Id)
        {
            Game g = GameRepository.GetGame(Id);
            return View(g);

        }
        public IActionResult EditingGame(Game g)
        {
            GameRepository.EditGame(g);
            return RedirectToAction("Games");

        }






        public IActionResult Companies()
        {
            var firmy = CompanyRepository.Company();
            return View(firmy);
        }

        public IActionResult AddCompany()
        {
            return View();
        }
        public IActionResult AddingCompany(Company c)
        {
            CompanyRepository.AddCompany(c);
            return RedirectToAction("Companies");
        }
        public IActionResult DeleteCompany(int Id)
        {
            CompanyRepository.DeleteCompany(Id);
            return RedirectToAction("Companies");
        }
        public IActionResult EditCompany(int Id)
        {
            Company c = CompanyRepository.GetCompany(Id);
            return View(c);

        }
        public IActionResult EditingCompany(Company c)
        {
            CompanyRepository.EditCompany(c);
            return RedirectToAction("Companies");

        }











        /*public IActionResult GetId(string NameGame, string NameCompany)
        {
            Game g = GameRepository.GetGameId(NameGame);
            Company c = CompanyRepository.GetCompanyId(NameCompany);
            if (g == null || c == null)
            {
                return View("Index");
            }
            else
            {

                return View("AskRelation", new { IdGame = g.Id, IdCompany = c.Id });
                //return RedirectToAction("AddId", new { IdGame = g.Id, IdCompany = c.Id });
            }
        }*/

        public IActionResult AddRel()
        {

        return View(); 
        }

        public IActionResult GetId(string NameGame, string NameCompany)
        {
            Game g = GameRepository.GetGameId(NameGame);
            Company c = CompanyRepository.GetCompanyId(NameCompany);

            if (g == null || c == null)
            {
                return View("Index");
            }
            else
            {
                RelId relId = new RelId { IdGame = g.Id, IdCompany = c.Id };
                return RedirectToAction("AskRel", new RelId { IdGame = g.Id, IdCompany = c.Id });
            }
        }
        public IActionResult AskRel(RelId model)
        {
            return View(model);
        }



        public IActionResult AddRelGTD(int IdCompany, int IdGame)
        {
            RelGTD gtd = new RelGTD(IdGame = IdGame, IdCompany = IdCompany);

            RelRepository.AddRelGTD(gtd);
            return RedirectToAction("Index");
        }
        public IActionResult AddRelGTP(int IdCompany, int IdGame)
        {
            RelGTP gtp = new RelGTP(IdGame = IdGame, IdCompany = IdCompany);

            RelRepository.AddRelGTP(gtp);
            return RedirectToAction("Index");
        }










        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
