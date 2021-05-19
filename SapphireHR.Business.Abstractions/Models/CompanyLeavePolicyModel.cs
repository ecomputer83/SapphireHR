using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class CompanyLeavePolicyModel
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }
        public LeavePolicyModel LeavePolicy { get; set; }
    }
}
