using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class CompanyLeavePolicy : BaseEntity
    {
        public int PolicyId { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("PolicyId")]
        public LeavePolicy LeavePolicy { get; set; }
    }
}
