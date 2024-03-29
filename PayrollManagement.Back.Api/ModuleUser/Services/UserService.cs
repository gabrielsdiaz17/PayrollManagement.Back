using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api.ModuleUser.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleUser.Services
{
    public class UserService : BaseRepository<User>, IUserService
    {
        public UserService(IRepository<User> repository) : base(repository)
        {

        }
        public async Task<User> GetUserLogin(UserLogin login)
        {
            var user = await QueryNoTracking().Where(us => us.Name == login.Name && us.Password == login.Password)
                .Include(us => us.UserInfo)
                .Include(us => us.CostCenter)
                .Include(us => us.Role)
                .FirstOrDefaultAsync();
            return user;
        }

        public async Task<List<User>> GetUserWithUserInfo()
        {
            var usersWithUserInfo = await QueryNoTracking()
                .Include(us => us.UserInfo)
                .Include(us => us.CostCenter)
                .Include(us => us.Role)
                .ToListAsync();
            return usersWithUserInfo;
        }
        public async Task<User> GetUserByCostCenter(long costCenterId)
        {
            var user = await QueryNoTracking().Where(us=> us.CostCenterId == costCenterId).FirstOrDefaultAsync();
            return user;
        }
    }
}
