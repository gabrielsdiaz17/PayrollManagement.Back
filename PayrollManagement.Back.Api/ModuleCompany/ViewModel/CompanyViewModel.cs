using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleCompany.ViewModel
{
    public class CompanyViewModel : Auditable
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public long CityId { get; set; }

    }
    public class CompanySearchViewModel : CompanyViewModel
    {
        public City City { get; set; }
    }
}
