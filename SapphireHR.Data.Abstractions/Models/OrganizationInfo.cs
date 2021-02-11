using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class OrganizationInfo : BaseEntity
    {
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactAddress { get; set; }
        public string Directory { get; set; }
        public string RegistrationNumber { get; set; } // CAC number
        public OrganizationHeader OrganizationHeader { get; set; }
        public ICollection<CompanyInfo> Companies { get; set; }
    }
}
