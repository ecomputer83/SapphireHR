using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class LeavePolicy : BaseEntity
    {
        public int SettingId { get; set; }
        public string PolicyName { get; set; }
        public int Days { get; set; }

        [ForeignKey("SettingId")]
        public LeaveSetting LeaveSetting { get; set; }
        public virtual List<CompanyLeavePolicy> CompanyLeavePolicies { get; set; }
    }

}
