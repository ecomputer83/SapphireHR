using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeSalaryModel
    {
        public double Basic { get; set; }
        public double HRA { get; set; }
        public double MA { get; set; }
        public double PF { get; set; }
        public double Allowance { get; set; }
        public double LeaveAllowance { get; set; }
        public double HMO { get; set; }
        public double Tax { get; set; }
        public double NetSalary { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
