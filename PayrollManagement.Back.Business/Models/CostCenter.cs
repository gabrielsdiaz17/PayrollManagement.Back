﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Business.Models
{
    public class CostCenter : Auditable
    {
        public string Name { get; set; }
        //[ForeignKey("User")]
        public string CostCenterCode { get; set; }
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public virtual IList<Worker> Workers { get; set; }
        public long ParentId { get; set; }
        public TimeSpan EntryHourCC { get; set; }
        public TimeSpan ExitHourCC { get; set; }
        public TimeSpan EntryHourCCSaturday { get; set; }
        public TimeSpan ExitHourCCSaturday { get; set; }
    }
}
