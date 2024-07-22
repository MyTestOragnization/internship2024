using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test4.Dal;
using test4.Models;



namespace test4.Controllers
{
    public class HomeController : Controller
    {
        public MyDbContext DbContext { get; set; }
        //        private AlbumEntity AlbumEntityRepository = new AlbumEntity();
        public IAlbumEFRepository AlbumEFRepository { get; set; }
        public ISaleEFRepository SaleEFRepository { get; set; }
        //private SaleRepository saleRepository = new SaleRepository();
        private UsersRepository usersRepository = new UsersRepository();
        private AlbumRepository albumRepository = new AlbumRepository();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyDbContext dbContext, IAlbumEFRepository albumRepository,ISaleEFRepository saleEFRepository)
        {
            _logger = logger;
            DbContext = dbContext;
            AlbumEFRepository = albumRepository;
            SaleEFRepository = saleEFRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sale()
        {
            ViewBag.List = SaleEFRepository.GetSalesExt();
            return View();
        }
        public IActionResult BeforeSale(int IdAlbum, int IdUser)
        {
            SaleEFRepository.AddSale(IdAlbum, IdUser);
            Album a = AlbumEFRepository.GetAlbum(IdAlbum);
            a.Amount --;
            AlbumEFRepository.EditAlbum(a);
            return RedirectToAction("Sale");
        }
        public IActionResult AddUser()
        {
            return View();
        }
        public IActionResult AddAlbum()
        {
            return View();
        }
        public IActionResult AfterAddAlbum(Album a)
        {
            AlbumEFRepository.AddAlbum(a);
            return RedirectToAction("Albumy");
        }
        public IActionResult Albumy()
        {
           // AlbumEFRepository.AddAlbum();
            ViewBag.List = AlbumEFRepository.GetAlbumy();

            return View();
        }
        public IActionResult AlbumyBuy(int Id)
        {
            ViewBag.Id = Id;
            ViewBag.list = albumRepository.GetAlbumy();

            return View();
        }

        public IActionResult UserList()
        {

            var list2 = usersRepository.GetUsers();
            return View(list2);
        }
        public IActionResult EditAlbum(int Id)
        {

            Album a = AlbumEFRepository.GetAlbum(Id);
            return View(a);
        }
        public IActionResult DeleteUser(int Id)
        {
            usersRepository.DeleteUser(Id);
            return RedirectToAction("UserList");
        }
        public IActionResult DeleteAlbum(int Id)
        {
            AlbumEFRepository.DeleteAlbum(Id);
            return RedirectToAction("Albumy");
        }
        public IActionResult AfterEditAlbum(Album a)
        {
            //asdddddddddddddddddddddddddddddddddddddddddssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss
            AlbumEFRepository.EditAlbum(a);
            return RedirectToAction("Albumy");
        }

        public IActionResult AfterEditorUsers(Users u)
        {
               usersRepository.EditUser(u);
 
            return RedirectToAction("UserList");
        }
        public IActionResult AfterAddUser(Users u)
        {
            usersRepository.AddUser(u);
            return RedirectToAction("UserList");
        }
        public IActionResult AfterDeletSale(int Id)
        {
            SaleEFRepository.DeleteSale(Id);
            return RedirectToAction("Sale");
        }
        public IActionResult EditUser(int Id)
        {

            //  usersRepository.EditingUsers(1, "Ala", "Ma", "Kota");
            List<Users> list = usersRepository.GetUser(Id);
            return View(list[0]);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
