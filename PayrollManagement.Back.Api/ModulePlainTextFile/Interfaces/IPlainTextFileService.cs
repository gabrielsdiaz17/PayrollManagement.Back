using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.HelperModels;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModulePlainTextFile.Interfaces
{
    public interface IPlainTextFileService:IRepository<PlainTextFile>
    {
        Task <List<PlainTextFile>> GetAll ();
        Task <List <PlainTextFile>> GetPlainTextByDate (DateGeneralFilter filter);
    }
}
