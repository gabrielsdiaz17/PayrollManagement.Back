using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api.ModulePlainTextFile.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModulePlainTextFile.Services
{
    public class PlainTextFileRecordService : BaseRepository<PlainTextFileRecord>, IPlainTextFileRecordService
    {
        public PlainTextFileRecordService(IRepository<PlainTextFileRecord> repository) : base(repository)
        {
        }

    }
}
