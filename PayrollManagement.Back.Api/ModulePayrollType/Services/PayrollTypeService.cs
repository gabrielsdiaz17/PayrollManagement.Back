using PayrollManagement.Back.Api.ModulePayrollType.Interface;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModulePayrollType.Services
{
    public class PayrollTypeService : BaseRepository<PayrollType>, IPayrollTypeService
    {
        public PayrollTypeService(IRepository<PayrollType> repository) : base(repository)
        {
        }
    }
}
