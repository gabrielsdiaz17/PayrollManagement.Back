using PayrollManagement.Back.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Business.Models
{
    public class ParametrizationNovelty: Auditable
    {
        public string NoveltyName { get; set; }
        public string Type { get; set; }
        public int NoveltyLength { get; set; }
        public int InitialPosition { get; set; }
        public int FinalPosition { get; set; }
        public string Justification { get; set; }
        public Justification Justification { get; set; }
    }
}
