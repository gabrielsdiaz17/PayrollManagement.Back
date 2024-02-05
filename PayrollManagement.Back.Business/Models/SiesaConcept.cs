using PayrollManagement.Back.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Business.Models
{
    public class SiesaConcept: Auditable
    {
        public string ConceptCode { get; set; }
        public string Abbreviation { get; set; }
        public TypeNovelty TypeNovelty { get; set; }
        public int LiquidationMode { get; set; }
        public string LiquidationModeDescription { get; set; }
    }
}
