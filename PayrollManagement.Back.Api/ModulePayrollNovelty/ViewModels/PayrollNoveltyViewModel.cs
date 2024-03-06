using PayrollManagement.Back.Api.ModuleUserActivity.ViewModel;
using PayrollManagement.Back.Api.ModuleUserInfo.ViewModel;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModulePayrollNovelty.ViewModels
{
    public class PayrollNoveltyViewModel: Auditable
    {
        public long SiesaConceptId { get; set; }
        public long UserInfoId { get; set; }
        public long? UserActivityId { get; set; }
        public DateTime NoveltyDate { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DaysDurationNotWorking { get; set; }
        public int Duration { get; set; }
        public decimal ValueNovelty { get; set; }
    }
    public class PayrollNoveltyDetailViewModel
    {
        public SiesaConcept SiesaConcept { get; set; }
        public UserInfoViewModel UserInfo { get; set; }
        public UserActivityViewModel? UserActivity { get; set; }
    }
}
