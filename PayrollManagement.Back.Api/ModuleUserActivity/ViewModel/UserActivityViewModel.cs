using PayrollManagement.Back.Api.ModuleUser.ViewModel;
using PayrollManagement.Back.Api.ModuleWorker.ViewModel;
using PayrollManagement.Back.Business.Enums;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleUserActivity.ViewModel
{
    public class UserActivityViewModel : Auditable
    {
        public long UserId { get; set; }
        public long WorkerId { get; set; }
        public DateTime DateActivity { get; set; }
        public TypeActivity TypeActivity { get; set; }
        public string Observation { get; set; }

    }
    public class UserActivityViewModelDetails : UserActivityViewModel
    {
        public UserQueryViewModel User { get; set; }
        public WorkerQueryViewModel Worker { get; set; }
    }
}
