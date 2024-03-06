using PayrollManagement.Back.Api.ModuleSiesaConcept.Interfaces;
using PayrollManagement.Back.Business.Models;
using PayrollManagement.Back.Infraestructure.Repository;

namespace PayrollManagement.Back.Api.ModuleSiesaConcept.Services
{
    public class SiesaConceptService : BaseRepository<SiesaConcept>, ISiesaConceptService
    {
        public SiesaConceptService(IRepository<SiesaConcept> repository) : base(repository)
        {
        }
    }
}
