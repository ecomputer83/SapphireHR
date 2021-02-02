using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class CompanyLeavePolicy : BaseEntity
    {
        public int PolicyId { get; set; }
        public int EmployeeId { get; set; }
    }
}
