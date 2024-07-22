using Microsoft.EntityFrameworkCore;
using test4.Models;

namespace test4.Dal
{
    public interface ISaleEFRepository
    {

        public IEnumerable<Sale> GetSales();
        public IEnumerable<SaleNice> GetSalesExt();
        public void DeleteSale(int Id);
        public void AddSale(int IdAlbum, int IdUser);

    }
}
