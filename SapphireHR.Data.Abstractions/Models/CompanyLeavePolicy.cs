using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class CompanyLeavePolicy : BaseEntity
    {
        public int PolicyId { get; set; }
        public int EmployeeId { get; set; }
    }
}
