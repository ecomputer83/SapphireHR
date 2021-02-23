using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeLeaveModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set;  }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Reason { get; set; }
        public int? ApprovedBy { get; set; }
        public LeaveTypeModel LeaveType { get; set; }
        public EmployeeLeaveModel EmployeeLeave { get; set; }
    }
}
