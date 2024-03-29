using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleWorker.Interfaces
{
    public interface IWorkerService : IRepository<Worker>
    {
        Task<List<Worker>> GetWorkerWithUserInfo();
        Task<List<Worker>> GetUserActivityByWorker(long workerId);
        Task<List<Worker>> WorkerByCostCenter(long costCenterId);
    }
}
