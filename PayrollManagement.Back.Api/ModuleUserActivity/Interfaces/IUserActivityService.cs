using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleUserActivity.Interfaces
{
    public interface IUserActivityService : IRepository<UserActivity>
    {
        Task<List<UserActivity>> GetAcitivityByDates(UserActivityFilter filter);
        Task<List<UserActivity>> GetActivityByWorkerId(UserActivitityFilterWorkerId activity);

        Task<List<UserActivity>> GetActivityByCostCenter(CostCenterActivityFilter filter);
    }
}
