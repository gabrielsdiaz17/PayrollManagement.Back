﻿using PayrollManagement.Back.Business.Enums;
using PayrollManagement.Back.Business.Models;

namespace PayrollManagement.Back.Api.ModuleUserInfo.ViewModel
{
    public class UserInfoViewModel : Auditable
    {
        public long? UserId { get; set; }
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
        public long? WorkerId { get; set; }
        public TimeSpan EntryHour { get; set; }
        public TimeSpan ExitHour { get; set; }
        public long? PayrollTypeId { get; set; }
        public decimal? Salary { get; set; }

    }
}
