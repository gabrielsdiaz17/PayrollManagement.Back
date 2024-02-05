using PayrollManagement.Back.Api.ModuleCostCenter.ViewModel;
using PayrollManagement.Back.Api.ModuleUserActivity.ViewModel;
using PayrollManagement.Back.Api.ModuleUserInfo.ViewModel;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleWorker.ViewModel
{
    public class WorkerViewModel : Auditable
    {
        public long CostCenterId { get; set; }
        public long UserInfoId { get; set; }
        public long CompanyId { get; set; }

    }
    public class WorkerQueryViewModel : WorkerViewModel
    {
        public UserInfoViewModel UserInfo { get; set; }
        public CostCenterViewModel CostCenter { get; set; }
    }
    public class WorkerQueryUserActivity : WorkerViewModel
    {
        public virtual List<UserActivityViewModel> UserActivities { get; set; }
    }
}
