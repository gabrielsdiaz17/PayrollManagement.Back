﻿using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api.ModuleWorker.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleWorker.Services
{
    public class WorkerService : BaseRepository<Worker>, IWorkerService
    {
        private readonly IRepository<Worker> _workerRepository;
        public WorkerService(IRepository<Worker> repository) : base(repository)
        {
            _workerRepository = repository;
        }
        public async Task<List<Worker>> GetUserActivityByWorker(long wokerId)
        {
            var userActivityByWorker = await QueryNoTracking().Where(w => w.Id == wokerId)
                .Include(u => u.UserActivities).ToListAsync();
            return userActivityByWorker;
        }

        public async Task<List<Worker>> GetWorkerWithUserInfo()
        {
            var workersWithUserInfo = await QueryNoTracking().Include(u => u.UserInfo)
                .Include(u => u.CostCenter)
                .ToListAsync();
            return workersWithUserInfo;
        }
        public async Task<List<Worker>> WorkerByCostCenter(long costCenterId)
        {
            var workersbyCostCenterId = await QueryNoTracking().Where(worker => worker.CostCenterId == costCenterId).ToListAsync();
            return workersbyCostCenterId;
        }
    }
}
