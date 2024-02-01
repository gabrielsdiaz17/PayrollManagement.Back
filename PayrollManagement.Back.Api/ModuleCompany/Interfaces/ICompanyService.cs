using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleCompany.Interfaces
{
    public interface ICompanyService : IRepository<Company>
    {
        Task<List<Company>> GetCompaniesWithCities();
    }
}
