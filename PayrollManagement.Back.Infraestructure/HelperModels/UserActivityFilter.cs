using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Infraestructure.HelperModels
{
    public class UserActivityFilter
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    public class UserActivitityFilterWorkerId 
    {
        public long WorkerId { get; set; }
    }
    public class DateGeneralFilter: UserActivityFilter
    {

    }
    public class DateGeneralFilterWithUserInfo: DateGeneralFilter 
    {
        public string DocumentNumber { get; set; }
    }
    public class CostCenterActivityFilter : UserActivityFilter 
    {
        public long CostCenterId { get; set; }
    }
}
