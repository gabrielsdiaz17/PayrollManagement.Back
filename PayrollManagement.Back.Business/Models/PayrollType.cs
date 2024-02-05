using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Business.Models
{
    public class PayrollType: Auditable
    {
        public string TypePayroll { get; set; }
        public string Nomenclature { get; set; }
        public int DaysPayment { get; set; }
    }
}
