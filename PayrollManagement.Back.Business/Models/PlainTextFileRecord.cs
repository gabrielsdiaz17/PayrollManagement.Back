using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Business.Models
{
    public class PlainTextFileRecord: Auditable
    {
        public int PlainTextFileId { get; set; }
        public PlainTextFile PlainTextFile { get; set; }
        public string Record { get; set; }
        public bool ProcessedRecord { get; set; }
    }
}
