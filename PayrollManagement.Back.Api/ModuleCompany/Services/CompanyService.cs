using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api.ModuleCompany.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleCompany.Services
{
    public class CompanyService : BaseRepository<Company>, ICompanyService
    {
        public CompanyService(IRepository<Company> repository) : base(repository)
        {
        }
        public async Task<List<Company>> GetCompaniesWithCities()
        {
            var allCompanies = await QueryNoTracking().Include(c => c.City).ToListAsync();
            return allCompanies;
        }
    }
}
