using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api.ModulePayrollNovelty.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModulePayrollNovelty.Services
{
    public class PayrollNoveltyService : BaseRepository<PayrollNovelty>, IPayrollNoveltyService
    {
        public PayrollNoveltyService(IRepository<PayrollNovelty> repository) : base(repository)
        {
        }

        public async Task<List<PayrollNovelty>> GetPayrollNoveltiesByDate(DateGeneralFilter dateFilter)
        {
            var novelties  = await QueryNoTracking().Where(novelty => novelty.InitialDate >= dateFilter.StartDate && novelty.EndDate <= dateFilter.EndDate)
                .Include(ui=> ui.UserInfo)
                .Include(ua => ua.UserActivity)
                .Include(si=> si.SiesaConcept)
                .ToListAsync();
            return novelties;
        }

        public async Task<List<PayrollNovelty>> GetPayrollNoveltiesByUserInfo(DateGeneralFilterWithUserInfo filter)
        {
            var novelties = await QueryNoTracking().Where(novelty => novelty.InitialDate >= filter.StartDate && novelty.EndDate <= filter.EndDate && novelty.UserInfoId == filter.UserInfoId )
                .Include(ui => ui.UserInfo)
                .Include(ua => ua.UserActivity)
                .Include(si=> si.SiesaConcept)
                .ToListAsync();
            return novelties;
        }
    }
}
