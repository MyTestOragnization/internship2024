using test4.Models;
//using test4.Dal;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.SqlServer;
namespace test4.Dal
{                                                
    public class AlbumEFRepository : IAlbumEFRepository
    {                                                                
        private MyDbContext _dbContext;
        public AlbumEFRepository(MyDbContext context) {
            _dbContext = context;
        }
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
        }
        public IEnumerable<Album> GetAlbumy()
        {

            IEnumerable<Album> a;
            try
            {
                a = _dbContext.Album.ToList();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return a;
        }
        public IEnumerable<AlbumNice> GetAlbumyNice()
        {
            var tmp = _dbContext.MTMAlbumAuthor.Join(_dbContext.Author, s => s.IdAlbum, a => a.Id, (s, a) => new { s, a })
            .Join(_dbContext.Album, x => x.s.IdAlbum, u => u.Id, (x, u) => new AlbumNice()
            {
                Id = x.s.Id,
                AlbumName = u.AlbumName,
                Name = x.a.Name,
                YearReleaseAlbum = u.YearReleaseAlbum,
                MadeIn = u.MadeIn,
                Price = u.Price,
                Amount = u.Amount
            }).ToList();
            return tmp;
        }
    }
        

    
}
