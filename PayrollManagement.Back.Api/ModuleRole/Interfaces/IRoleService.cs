using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleRole.Interfaces
{
    public interface IRoleService : IRepository<Role>
    {
    }
}
