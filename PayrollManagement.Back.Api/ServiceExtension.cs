using PayrollManagement.Back.Api.ModuleCity.Interfaces;
using PayrollManagement.Back.Api.ModuleCity.Services;
using PayrollManagement.Back.Api.ModuleCompany.Interfaces;
using PayrollManagement.Back.Api.ModuleCompany.Services;
using PayrollManagement.Back.Api.ModuleCostCenter.Interfaces;
using PayrollManagement.Back.Api.ModuleCostCenter.Services;
using PayrollManagement.Back.Api.ModuleParametrizationNovelty.Interface;
using PayrollManagement.Back.Api.ModuleParametrizationNovelty.Services;
using PayrollManagement.Back.Api.ModulePayrollNovelty.Interfaces;
using PayrollManagement.Back.Api.ModulePayrollNovelty.Services;
using PayrollManagement.Back.Api.ModulePayrollType.Interface;
using PayrollManagement.Back.Api.ModulePayrollType.Services;
using PayrollManagement.Back.Api.ModulePlainTextFile.Interfaces;
using PayrollManagement.Back.Api.ModulePlainTextFile.Services;
using PayrollManagement.Back.Api.ModuleRegion.Interfaces;
using PayrollManagement.Back.Api.ModuleRegion.Services;
using PayrollManagement.Back.Api.ModuleRole.Interfaces;
using PayrollManagement.Back.Api.ModuleRole.Services;
using PayrollManagement.Back.Api.ModuleSiesaConcept.Interfaces;
using PayrollManagement.Back.Api.ModuleSiesaConcept.Services;
using PayrollManagement.Back.Api.ModuleUser.Interfaces;
using PayrollManagement.Back.Api.ModuleUser.Services;
using PayrollManagement.Back.Api.ModuleUserActivity.Interfaces;
using PayrollManagement.Back.Api.ModuleUserActivity.Services;
using PayrollManagement.Back.Api.ModuleUserInfo.Interfaces;
using PayrollManagement.Back.Api.ModuleUserInfo.Services;
using PayrollManagement.Back.Api.ModuleWorker.Interfaces;
using PayrollManagement.Back.Api.ModuleWorker.Services;
using PayrollManagement.Back.Api.Profiles;

namespace PayrollManagement.Back.Api
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddCustomizedServices(this IServiceCollection services)
        {
            services.AddTransient<IWorkerService, WorkerService>();
            services.AddTransient<ICostCenterService, CostCenterService>();
            services.AddTransient<IUserActivityService, UserActivityService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IRegionService, RegionService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IUserInfoService, UserInfoService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ISiesaConceptService, SiesaConceptService>();
            services.AddTransient<INoveltyParametrizationService, NoveltyParametrizationService>();
            services.AddTransient<IPayrollNoveltyService, PayrollNoveltyService>();
            services.AddTransient<IPayrollTypeService, PayrollTypeService>();
            services.AddTransient<IPlainTextFileService, PlainTextFileService>();
            services.AddTransient<IPlainTextFileRecordService, PlainTextFileRecordService>();

            //Mapping
            services.AddAutoMapper(typeof(ServiceExtension));
            services.AddAutoMapper(typeof(CityMappingProfile));
            services.AddAutoMapper(typeof(CompanySearchMappingProfile));
            services.AddAutoMapper(typeof(CompanyMappingProfile));
            services.AddAutoMapper(typeof(CostCenterMappingProfile));
            services.AddAutoMapper(typeof(RoleMappingProfile));
            services.AddAutoMapper(typeof(UserMappingProfile));
            services.AddAutoMapper(typeof(UserInfoMappingProfile));
            services.AddAutoMapper(typeof(WorkerMappingProfile));
            services.AddAutoMapper(typeof(UserActivityMappingProfile));
            services.AddAutoMapper(typeof(WorkerUserInfoMappingProfile));
            services.AddAutoMapper(typeof(WorkerUserActivityMappingProfile));
            services.AddAutoMapper(typeof(UserUserInfoMappingProfile));
            services.AddAutoMapper(typeof(CostCenterQueryMappingProfile));
            services.AddAutoMapper(typeof(LoginMappingProfile));
            services.AddAutoMapper(typeof(UserActivityWorkerUserInfoMappingProfile));
            services.AddAutoMapper(typeof(PayrollNoveltyMappingProfile));
            services.AddAutoMapper(typeof(PayrollNoveltyDetailViewModelMappingProfile));
            services.AddAutoMapper(typeof(PlainTextFileViewModelMappingProfile));
            services.AddAutoMapper(typeof(PlainTextFileWithRecordsViewModelMappingProfile));
            services.AddAutoMapper(typeof(PlainTextFileRecordViewModelMappingProfile));

            return services;
        }
    }
}
