using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class LeavePolicyModel
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string PolicyName { get; set; }
        public int Days { get; set; }
        public LeaveTypeModel LeaveType { get; set; }
        public virtual List<CompanyLeavePolicyModel> CompanyLeavePolicies { get; set; }
    }
}
