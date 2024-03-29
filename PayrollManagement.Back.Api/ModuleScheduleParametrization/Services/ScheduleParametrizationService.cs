using PayrollManagement.Back.Api.ModuleScheduleParametrization.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleScheduleParametrization.Services
{
    public class ScheduleParametrizationService : BaseRepository<ScheduleParametrization>, IScheduleParametrizationService
    {
        public ScheduleParametrizationService(IRepository<ScheduleParametrization> repository) : base(repository)
        {
        }
    }
}
