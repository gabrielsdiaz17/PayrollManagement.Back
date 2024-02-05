using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleUserInfo.Interfaces
{
    public interface IUserInfoService : IRepository<UserInfo>
    {
    }
}
