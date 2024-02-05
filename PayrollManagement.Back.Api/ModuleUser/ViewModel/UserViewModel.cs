using PayrollManagement.Back.Api.ModuleCostCenter.ViewModel;
using PayrollManagement.Back.Api.ModuleRole.ViewModel;
using PayrollManagement.Back.Api.ModuleUserInfo.ViewModel;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleUser.ViewModel
{
    public class UserViewModel : Auditable
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }
        public long? CostCenterId { get; set; }
        public long UserInfoId { get; set; }
        public long? CompanyId { get; set; }


    }
    public class UserQueryViewModel : UserViewModel
    {
        public UserInfoViewModel UserInfo { get; set; }
        public CostCenterViewModel CostCenter { get; set; }
        public RoleViewModel Role { get; set; }
    }
    public class UserLoginViewModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
