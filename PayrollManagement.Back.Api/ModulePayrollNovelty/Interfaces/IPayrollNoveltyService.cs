using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModulePayrollNovelty.Interfaces
{
    public interface IPayrollNoveltyService: IRepository<PayrollNovelty>
    {
        Task <List<PayrollNovelty>> GetPayrollNoveltiesByDate(DateGeneralFilter dateFilter);
        Task<List<PayrollNovelty>> GetPayrollNoveltiesByUserInfo(DateGeneralFilterWithUserInfo filter);

    }
}
