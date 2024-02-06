using AutoMapper;
using PayrollManagement.Back.Api.ModuleCity.ViewModel;
using PayrollManagement.Back.Api.ModuleCompany.ViewModel;
using PayrollManagement.Back.Api.ModuleCostCenter.ViewModel;
using PayrollManagement.Back.Api.ModulePayrollNovelty.ViewModels;
using PayrollManagement.Back.Api.ModulePlainTextFile.ViewModels;
using PayrollManagement.Back.Api.ModuleRole.ViewModel;
using PayrollManagement.Back.Api.ModuleUser.ViewModel;
using PayrollManagement.Back.Api.ModuleUserActivity.ViewModel;
using PayrollManagement.Back.Api.ModuleUserInfo.ViewModel;
using PayrollManagement.Back.Api.ModuleWorker.ViewModel;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;

namespace PayrollManagement.Back.Api.Profiles
{
    public class CityMappingProfile : Profile
    {
        public CityMappingProfile()
        {
            CreateMap<CityViewModel, City>().ReverseMap();
        }
    }
    public class CompanyMappingProfile : Profile
    {
        public CompanyMappingProfile()
        {
            CreateMap<CompanyViewModel, Company>().ReverseMap();
        }
    }
    public class CompanySearchMappingProfile : Profile
    {
        public CompanySearchMappingProfile()
        {
            CreateMap<Company, CompanySearchViewModel>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City));
        }
    }

    public class CostCenterMappingProfile : Profile
    {
        public CostCenterMappingProfile()
        {
            CreateMap<CostCenter, CostCenterViewModel>().ReverseMap();
        }
    }
    public class RoleMappingProfile : Profile
    {
        public RoleMappingProfile()
        {
            CreateMap<Role, RoleViewModel>().ReverseMap();
        }
    }
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
    public class UserInfoMappingProfile : Profile
    {
        public UserInfoMappingProfile()
        {
            CreateMap<UserInfo, UserInfoViewModel>().ReverseMap();
        }
    }
    public class WorkerMappingProfile : Profile
    {
        public WorkerMappingProfile()
        {
            CreateMap<Worker, WorkerViewModel>().ReverseMap();
        }
    }
    public class WorkerUserInfoMappingProfile : Profile
    {
        public WorkerUserInfoMappingProfile()
        {
            CreateMap<Worker, WorkerQueryViewModel>()
                .ForMember(dest => dest.UserInfo, opt => opt.MapFrom(src => src.UserInfo))
                .ForMember(dest => dest.CostCenter, opt => opt.MapFrom(src => src.CostCenter));
        }
    }
    public class UserActivityMappingProfile : Profile
    {
        public UserActivityMappingProfile()
        {
            CreateMap<UserActivity, UserActivityViewModel>().ReverseMap();
        }
    }

    public class WorkerUserActivityMappingProfile : Profile
    {
        public WorkerUserActivityMappingProfile()
        {
            CreateMap<Worker, WorkerQueryUserActivity>()
                .ForMember(dest => dest.UserActivities, opt => opt.MapFrom(src => src.UserActivities));
        }
    }
    public class UserUserInfoMappingProfile : Profile
    {
        public UserUserInfoMappingProfile()
        {
            CreateMap<User, UserQueryViewModel>()
                .ForMember(dest => dest.UserInfo, opt => opt.MapFrom(src => src.UserInfo))
                .ForMember(dest => dest.CostCenter, opt => opt.MapFrom(src => src.CostCenter))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role));
        }
    }

    public class CostCenterQueryMappingProfile : Profile
    {
        public CostCenterQueryMappingProfile()
        {
            CreateMap<CostCenter, CostCenterQueryViewModel>().
                ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));
        }
    }
    public class LoginMappingProfile : Profile
    {
        public LoginMappingProfile()
        {
            CreateMap<UserLogin, UserLoginViewModel>().ReverseMap();
        }
    }
    public class UserActivityWorkerUserInfoMappingProfile : Profile
    {
        public UserActivityWorkerUserInfoMappingProfile()
        {
            CreateMap<UserActivity, UserActivityViewModelDetails>()
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User))
                .ForMember(dest => dest.Worker, opt => opt.MapFrom(src => src.Worker));
        }
    }
    public class PayrollNoveltyMappingProfile : Profile
    {
        public PayrollNoveltyMappingProfile()
        {
            CreateMap<PayrollNovelty, PayrollNoveltyViewModel > ().ReverseMap();
        }
    }
    public class PayrollNoveltyDetailViewModelMappingProfile : Profile
    {
        public PayrollNoveltyDetailViewModelMappingProfile()
        {
            CreateMap<PayrollNovelty, PayrollNoveltyDetailViewModel>()
                .ForMember(dest => dest.UserInfo, opt => opt.MapFrom(src => src.UserInfo))
                .ForMember(dest => dest.UserActivity, opt=> opt.MapFrom(src =>src.UserActivity));
        }
    }
    public class PlainTextFileViewModelMappingProfile: Profile
    {
        public PlainTextFileViewModelMappingProfile()
        {
            CreateMap<PlainTextFile, PlainTextFileViewModel>().ReverseMap();
        }
    }
    public class PlainTextFileWithRecordsViewModelMappingProfile: Profile
    {
        public PlainTextFileWithRecordsViewModelMappingProfile()
        {
            CreateMap<PlainTextFile, PlainTextFileWithRecordsViewModel>()
                .ForMember(dest => dest.PlainTextFileRecords, opt => opt.MapFrom(src => src.PlainTextFileRecords));
        }
    }
    public class PlainTextFileRecordViewModelMappingProfile: Profile
    {
        public PlainTextFileRecordViewModelMappingProfile()
        {
            CreateMap<PlainTextFileRecord, PlainTextFileRecordViewModel>().ReverseMap();
        }
    }

}
