using PayrollManagement.Back.Api.ModuleUserInfo.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleUserInfo.Services
{
    public class UserInfoService : BaseRepository<UserInfo>, IUserInfoService
    {
        public UserInfoService(IRepository<UserInfo> repository) : base(repository)
        {
        }
    }
}
