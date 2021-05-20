using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class LeaveSettingModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int TypeId { get; set; }
        public int Days { get; set; }
        public bool CarryOver { get; set; }
        public int CarryOverMax { get; set; }
        public bool EarnedLeave { get; set; }
        public int Status { get; set; }
        public CompanyModel CompanyInfo { get; set; }
        public LeaveTypeModel LeaveType { get; set; }
        public List<LeavePolicyModel> LeavePolicies { get; set; }
    }
}
