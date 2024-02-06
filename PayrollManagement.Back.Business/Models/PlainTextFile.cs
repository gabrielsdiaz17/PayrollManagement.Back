using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Business.Models
{
    public class PlainTextFile: Auditable
    {
        public string Period { get; set; }
        public DateTime DateUpload { get; set; }
        public virtual IList<PlainTextFileRecord> PlainTextFileRecords { get; set; }

    }
}
