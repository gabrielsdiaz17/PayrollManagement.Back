using PayrollManagement.Back.Api.ModuleCity.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleCity.Services
{
    public class CityService : BaseRepository<City>, ICityService
    {
        public CityService(IRepository<City> repository) : base(repository)
        {
        }
    }
}
