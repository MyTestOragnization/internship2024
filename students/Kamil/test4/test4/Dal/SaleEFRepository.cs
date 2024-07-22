using test4.Models;
using test4.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace test4.Dal
{
    public class SaleEFRepository : ISaleEFRepository
    {
        private MyDbContext _dbContext;
        public SaleEFRepository(MyDbContext context) {
            _dbContext = context;
        }
        /*
        public void EditAlbum(Album a)
        {
            try
            {
//                using (var context = new MyDbContext())
//                {
                    
                    _dbContext.Album.Update(a);
                    _dbContext.SaveChanges();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                //    var p = context.Albumy.FirstOrDefault(p=> p.Price <100m);
        }
        public Album GetAlbum(int Id)
        {

            Album a;
            try
            {
                
                a = _dbContext.Album.Single(b => b.Id == Id);
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return a;
        }
        public void DeleteAlbum(int Id)
        {
            try
            {
                Album a = _dbContext.Album.Single(b => b.Id == Id);
                _dbContext.Album.Remove(a);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            }
        public void AddAlbum(Album a)
        {
            try
            {
                //                using (var context = new MyDbContext())
                //                {

                //    a.Id = null;
                a.Id = 0;
                _dbContext.Album.Add(a);
                _dbContext.SaveChanges();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            //    var p = context.Albumy.FirstOrDefault(p=> p.Price <100m);
        }*/
        public IEnumerable<Sale> GetSales()
        {

            
            try
            {
                IEnumerable<Sale> a = _dbContext.Sale.ToList();
                return a;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return null;
        }
        public IEnumerable<SaleNice> GetSalesExt()
        {
            try
            {
                /*
                 * var appInformationToReturn = context.app_information
     .Join(
          context.app_language,
          ai => ai.languageid,
          al => al.id,
          (ai, al) => new AppInformation()
          {
               id = ai.id,
               title = ai.title,
               description = ai.description,
               coverimageurl = ai.coverimageurl
          })
     .Where()
     .FirstOrDefault();
                */

                var tmp = _dbContext.Sale.Join(_dbContext.Album, s => s.IdAlbum, a => a.Id, (s,a) => new { s, a })
                    .Join(_dbContext.Users, x => x.s.IdUser, u => u.Id, (x,u) => new SaleNice()
                {
                    Id = x.s.Id,
                    AlbumName = x.a.AlbumName,
                    IdAlbum = x.s.IdAlbum,
                    IdUser = x.s.IdUser,
                    Price = x.s.Price,
                    Name = u.Name

                }).ToList();

                return tmp;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return null;
        }
        public void DeleteSale(int Id)
        {
            try
            {
                Sale a = _dbContext.Sale.Single(b => b.Id == Id);
                _dbContext.Sale.Remove(a);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public void AddSale(int IdAlbum , int IdUser)
        {
            Sale s = new Sale();
            try
            {

                Album a = _dbContext.Album.Single(b => b.Id == IdAlbum);
                s.Price = Int32.Parse(a.Price);
                s.Id = 0;
                s.IdAlbum = IdAlbum;
                s.IdUser = IdUser;
                _dbContext.Sale.Add(s);
                _dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }

        }
    }
        

    
}
