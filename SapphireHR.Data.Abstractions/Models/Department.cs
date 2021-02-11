using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationInfo Organization { get; set; }
    }
}
