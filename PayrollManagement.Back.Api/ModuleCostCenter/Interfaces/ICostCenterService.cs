using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleCostCenter.Interfaces
{
    public interface ICostCenterService : IRepository<CostCenter>
    {
        Task<List<CostCenter>> GetCostCenterWithUser();

    }
}
