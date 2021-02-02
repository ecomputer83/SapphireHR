using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class CompanyInfo : BaseEntity
    {
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int OrganizationId { get; set; }
        [ForeignKey("OrganizationId")]
        public OrganizationInfo Organization { get; set; }
    }
}
