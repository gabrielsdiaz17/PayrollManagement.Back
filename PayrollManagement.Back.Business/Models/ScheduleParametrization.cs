using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Business.Models
{
    public class ScheduleParametrization : Auditable
    {
        public int Year { get; set; }
        public double WeekWorkingHours { get; set; }
        public double MonthlyWorkingHours { get; set; }
        public double ChargeOvertimeDaily { get; set; }
        public double ChargeOvertimeNightly { get; set; }
        public double ChargeOvertimeHolidayDaily { get; set; }
        public double ChargeOvertimeHolidayNightly { get; set; }
        public TimeSpan StartNightlyCharge { get; set; }
        public TimeSpan EndNightlyCharge { get; set; }
    }
}
