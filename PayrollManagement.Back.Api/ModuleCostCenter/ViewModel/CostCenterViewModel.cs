using PayrollManagement.Back.Api.ModuleUser.ViewModel;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleCostCenter.ViewModel
{
    public class CostCenterViewModel : Auditable
    {
        public string Name { get; set; }
        public string CostCenterCode { get; set; }        
        public long UserId { get; set; }
        public long CompanyId { get; set; }
        public long ParentId { get; set; }

    }
    public class CostCenterQueryViewModel : CostCenterViewModel
    {
        public UserViewModel User { get; set; }
    }
}
