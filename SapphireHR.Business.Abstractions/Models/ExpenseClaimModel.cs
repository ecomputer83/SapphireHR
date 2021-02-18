using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ExpenseClaimModel
    {
        public DateTimeOffset Date { get; set; }
        public string Remark { get; set; }
        public int Amount { get; set; }
        public int Assignee { get; set; }
        public int Approval { get; set; }
        public DateTimeOffset ApprovalDate { get; set; }
        public EmployeeModel ApprovalEmployee { get; set; }
        public EmployeeModel AssigneeEmployee { get; set; }
    }
}
