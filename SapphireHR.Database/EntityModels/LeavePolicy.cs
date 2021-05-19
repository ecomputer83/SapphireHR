using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class LeavePolicy : BaseEntity
    {
        public int CompanyId { get; set; }
        public int TypeId { get; set; }
        public string PolicyName { get; set; }
        public int Days { get; set; }

        [ForeignKey("TypeId")]
        public LeaveType LeaveType { get; set; }
        [ForeignKey("CompanyId")]
        public CompanyInfo Company  { get; set; }
        [NotMapped]
        public virtual List<CompanyLeavePolicy> CompanyLeavePolicies { get; set; }
    }
}
