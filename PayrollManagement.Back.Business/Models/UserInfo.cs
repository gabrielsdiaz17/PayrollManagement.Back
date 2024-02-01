using PayrollManagement.Back.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Back.Business.Models
{
    public class UserInfo : Auditable
    {
        //[ForeignKey("User")]
        public long? UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public IdentificationType IdentificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public string UserEmail { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EntryDate { get; set; }
        public long PhoneNumber { get; set; }
        public Genre Genre { get; set; }
        public string Address { get; set; }
        public long CityId { get; set; }
        public City City { get; set; }

        //[ForeignKey("Worker")]
        public long? WorkerId { get; set; }
        public Worker Worker { get; set; }
        public TimeSpan EntryHour { get; set; }
        public TimeSpan ExitHour { get; set; }
    }
}
