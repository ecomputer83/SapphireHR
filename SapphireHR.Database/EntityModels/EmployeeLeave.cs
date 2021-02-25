using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeLeave : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int Days { get; set; }
        public string Reason { get; set; }
        public int? ApprovedBy { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
    }
}
