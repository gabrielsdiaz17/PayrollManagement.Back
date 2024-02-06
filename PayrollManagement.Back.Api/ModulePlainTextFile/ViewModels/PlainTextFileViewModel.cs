using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModulePlainTextFile.ViewModels
{
    public class PlainTextFileViewModel: Auditable
    {
        public string Period { get; set; }
        public DateTime DateUpload { get; set; }
    }
    public class PlainTextFileWithRecordsViewModel: PlainTextFileViewModel
    {
        public virtual IList<PlainTextFileRecord> PlainTextFileRecords { get; set; }
    }
}
