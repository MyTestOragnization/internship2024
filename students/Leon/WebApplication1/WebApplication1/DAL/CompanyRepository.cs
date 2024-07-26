using WebApplication1.Models;
using WebApplication1.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Data.SqlClient;
using System.Collections;
namespace WebApplication1.Dal
{
    public class CompanyRepository : ICompanyRepository
    {
        private GDbContext dbContext;
        public CompanyRepository(GDbContext context)
        {
            dbContext = context;
        }

        /*        public Game SearchGame(string Name)
                {
                    throw new NotImplementedException();
                }*/

        public IEnumerable<Company> Company()
        {
            IEnumerable<Company> c;
            try
            {
                c = dbContext.Company.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return c;

        }

        
        public void DeleteCompany(int Id)
        {
            try
            {
                Company g = dbContext.Company.Single(x => x.Id == Id);
                dbContext.Company.Remove(g);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public Company GetCompany(int Id)
        {

            Company c;
            try
            {

                c = dbContext.Company.Single(b => b.Id == Id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return c;

        }
        public void EditCompany(Company company)
        {
            {
                try
                {
                    //                using (var context = new MyDbContext())
                    //                {

                    dbContext.Company.Update(company);
                    dbContext.SaveChanges();
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //    var p = context.Albumy.FirstOrDefault(p=> p.Price <100m);
            }
        }
        public void AddCompany(Company company)
        {
            try
            {
                company.Id = 0;
                dbContext.Company.Add(company);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }











        public Company GetCompanyId(string name)
        {

            Company c;
            try
            {

                c = dbContext.Company.Single(b => b.Name == name);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            return c;

        }



















    }
}
