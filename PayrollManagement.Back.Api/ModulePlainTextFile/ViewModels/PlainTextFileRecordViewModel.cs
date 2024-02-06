using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModulePlainTextFile.ViewModels
{
    public class PlainTextFileRecordViewModel: Auditable
    {
        public long PlainTextFileId { get; set; }
        public string Record { get; set; }
        public bool ProcessedRecord { get; set; }
    }
}
