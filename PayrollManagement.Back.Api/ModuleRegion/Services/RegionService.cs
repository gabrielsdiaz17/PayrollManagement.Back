using PayrollManagement.Back.Api.ModuleRegion.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleRegion.Services
{
    public class RegionService : BaseRepository<Region>, IRegionService
    {
        public RegionService(IRepository<Region> repository) : base(repository)
        {
        }
    }
}
