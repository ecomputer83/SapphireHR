using System.Collections.Generic;

namespace SapphireHR.Database.EntityModels
{
    public class OrganizationInfo : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string ContactPerson{get;set;}
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactAddress { get; set; }
        public string RegistrationNumber { get; set; } // CAC number
        public string Directory { get; set; }
        public OrganizationHeader OrganizationHeader { get; set; }
        public ICollection<CompanyInfo> Companies { get; set; }
    }
}