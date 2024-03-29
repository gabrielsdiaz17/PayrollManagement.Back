using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api.ModuleUser.Interfaces;
using PayrollManagement.Back.Api.ModuleUserActivity.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleUserActivity.Services
{
    public class UserActivityService : BaseRepository<UserActivity>, IUserActivityService
    {
        private readonly IUserService _userService;
        public UserActivityService(IRepository<UserActivity> repository, IUserService userService) : base(repository)
        {
            _userService = userService;
        }
        public async Task<List<UserActivity>> GetAcitivityByDates(UserActivityFilter filter)
        {
            var userActivityBetweenDates = await QueryNoTracking()
                .Where(ac => ac.DateActivity >= filter.StartDate && ac.DateActivity <= filter.EndDate)
                .Include(us => us.User)
                .Include(us => us.User.UserInfo)
                .Include(w => w.Worker)
                .ToListAsync();
            return userActivityBetweenDates;
        }

        public async Task<List<UserActivity>> GetActivityByWorkerId(UserActivitityFilterWorkerId activity)
        {
            var userActivityForUser = await QueryNoTracking()
                .Where(ac => ac.WorkerId == activity.WorkerId)
                .Include(us => us.User)
                .Include(w => w.Worker)
                .ToListAsync();
            return userActivityForUser;
        }

        public async Task<List<UserActivity>> GetActivityByCostCenter(CostCenterActivityFilter filter)
        {
            var user = await _userService.GetUserByCostCenter(filter.CostCenterId);
            var activities = await QueryNoTracking().Where(ac => ac.UserId == user.Id && ac.DateActivity >= filter.StartDate && ac.DateActivity <= filter.EndDate)
                .Include(us => us.User)
                .Include(us => us.User.UserInfo)
                .Include(w => w.Worker)
                .ToListAsync();
            return activities;
        }
    }
}
