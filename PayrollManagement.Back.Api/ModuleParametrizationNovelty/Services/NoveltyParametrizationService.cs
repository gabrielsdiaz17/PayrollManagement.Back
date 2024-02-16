using PayrollManagement.Back.Api.ModuleParametrizationNovelty.Interface;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleParametrizationNovelty.Services
{
    public class NoveltyParametrizationService : BaseRepository<ParametrizationNovelty>, INoveltyParametrizationService
    {
        public NoveltyParametrizationService(IRepository<ParametrizationNovelty> repository) : base(repository)
        {
        }
    }
}
