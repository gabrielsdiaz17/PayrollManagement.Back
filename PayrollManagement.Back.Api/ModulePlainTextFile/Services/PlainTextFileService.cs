using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api.ModulePlainTextFile.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModulePlainTextFile.Services
{
    public class PlainTextFileService : BaseRepository<PlainTextFile>, IPlainTextFileService
    {
        public PlainTextFileService(IRepository<PlainTextFile> repository) : base(repository)
        {
        }

        public async Task<List<PlainTextFile>> GetAll()
        {
            var plainTextFiles = await QueryNoTracking().Include(record=> record.PlainTextFileRecords).ToListAsync();      
            return plainTextFiles;
        }

        public async Task<List<PlainTextFile>> GetPlainTextByDate(DateGeneralFilter filter)
        {
            var plainTextFiles  = await QueryNoTracking().Where(file => file.DateUpload >= filter.StartDate && file.DateUpload <= filter.EndDate)
                .Include(file=> file.PlainTextFileRecords)
                .ToListAsync();
            return plainTextFiles;
        }
    }
}
