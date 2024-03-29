﻿using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api.ModulePayrollNovelty.Interfaces;
using PayrollManagement.Back.Api.ModuleUserInfo.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModulePayrollNovelty.Services
{
    public class PayrollNoveltyService : BaseRepository<PayrollNovelty>, IPayrollNoveltyService
    {
        private readonly IUserInfoService _userInfoService;
        public PayrollNoveltyService(IRepository<PayrollNovelty> repository, IUserInfoService userInfoService) : base(repository)
        {
            _userInfoService = userInfoService;
        }

        public async Task<List<PayrollNovelty>> GetPayrollNoveltiesByDate(DateGeneralFilter dateFilter)
        {
            var novelties  = await QueryNoTracking().Where(novelty => !novelty.ProcessedInFile &&
                novelty.InitialDate >= dateFilter.StartDate && novelty.EndDate <= dateFilter.EndDate)
                .Include(ui=> ui.UserInfo)
                .Include(ua => ua.UserActivity)
                .Include(si=> si.SiesaConcept)
                .ToListAsync();
            return novelties;
        }

        public async Task<List<PayrollNovelty>> GetPayrollNoveltiesByUserInfo(DateGeneralFilterWithUserInfo filter)
        {
            var userInfoId = await _userInfoService.GetUserInfoIdByDocument(filter.DocumentNumber);
            var novelties = await QueryNoTracking().Where(novelty => 
                novelty.InitialDate >= filter.StartDate && novelty.EndDate <= filter.EndDate && novelty.UserInfoId == userInfoId )
                .Include(ui => ui.UserInfo)
                .Include(ua => ua.UserActivity)
                .Include(si=> si.SiesaConcept)
                .ToListAsync();
            return novelties;
        }

        public async Task<List<PayrollNovelty>> GetPayrollNoveltiesNotProcessed()
        {
            var novelties = await QueryNoTracking().Where(novelty => !novelty.ProcessedInFile)
                .Include(ui => ui.UserInfo)
                .Include(ua => ua.UserActivity)
                .Include(si => si.SiesaConcept)
                .ToListAsync();
            return novelties;
        }
    }
}
