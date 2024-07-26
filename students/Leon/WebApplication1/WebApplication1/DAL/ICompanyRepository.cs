using WebApplication1.Models;

namespace WebApplication1.Dal
{
    public interface ICompanyRepository
    {
        public Company GetCompany(int Id);
        public IEnumerable<Company> Company();
        public void AddCompany(Company company);
        public void DeleteCompany(int Id);
        public void EditCompany(Company company);
    }
}
