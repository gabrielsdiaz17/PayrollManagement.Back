using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api.ModuleCostCenter.Interfaces;
using PayrollManagement.Back.Api.ModuleUser.Services;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleCostCenter.Services
{
    public class CostCenterService : BaseRepository<CostCenter>, ICostCenterService
    {        
        public CostCenterService(IRepository<CostCenter> repository) : base(repository)
        {
        }

    }
}
