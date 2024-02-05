using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleUser.Interfaces
{
    public interface IUserService : IRepository<User>
    {
        Task<List<User>> GetUserWithUserInfo();
        Task<User> GetUserLogin(UserLogin login);
    }
}
