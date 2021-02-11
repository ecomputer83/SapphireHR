using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class Designation : BaseEntity
    {
        public int DepartmentId { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public OrganizationInfo OrganizationInfo { get; set; }
    }
}
