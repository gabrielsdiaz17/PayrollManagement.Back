using PayrollManagement.Back.Api.ModuleRole.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleRole.Services
{
    public class RoleService : BaseRepository<Role>, IRoleService
    {
        public RoleService(IRepository<Role> repository) : base(repository)
        {
        }
    }
}
