using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModulePayrollType.Interface
{
    public interface IPayrollTypeService: IRepository<PayrollType>
    {
    }
}
