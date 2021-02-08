using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class OrganizationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactAddress { get; set; }
        public string RegistrationNumber { get; set; } // CAC number
        public string Directory { get; set; }
        public OrganizationHeaderModel OrganizationHeader { get; set; }
        public ICollection<CompanyModel> Companies { get; set; }
    }
}
