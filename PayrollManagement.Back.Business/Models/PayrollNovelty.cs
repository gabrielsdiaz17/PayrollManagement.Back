using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Business.Models
{
    public class PayrollNovelty: Auditable
    {
        public long SiesaConceptId { get; set; }
        public SiesaConcept SiesaConcept { get; set; }
        public long UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
        public long? UserActivityId { get; set; }
        public UserActivity? UserActivity { get; set;}
        public DateTime NoveltyDate { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DaysDurationNotWorking { get; set; }
        public int Duration { get; set; }
        public decimal ValueNovelty { get; set; }
    }
}
