using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api.ModuleUserActivity.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleUserActivity.Services
{
    public class UserActivityService : BaseRepository<UserActivity>, IUserActivityService
    {
        public UserActivityService(IRepository<UserActivity> repository) : base(repository)
        {
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

        public async Task<List<UserActivity>> GetActivityByDateAndUser(UserActivitityFilterWithUser activity)
        {
            var userActivityForUser = await QueryNoTracking()
                .Where(ac => ac.DateActivity >= activity.StartDate && ac.DateActivity <= activity.EndDate && ac.WorkerId == activity.UserId)
                .Include(us => us.User)
                .Include(w => w.Worker)
                .ToListAsync();
            return userActivityForUser;
        }
    }
}
