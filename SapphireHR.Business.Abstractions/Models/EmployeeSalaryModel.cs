using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeSalaryModel
    {
        public int Id { get; set; }
        public DateTime SalaryDate { get; set; }
        public double Basic { get; set; }
        public double HRA { get; set; }
        public double MA { get; set; }
        public double PF { get; set; }
        public double Allowance { get; set; }
        public double LeaveAllowance { get; set; }
        public double HMO { get; set; }
        public double Tax { get; set; }
        public double Others { get; set; }
        public  string Reasons { get; set; }
        public double NetSalary { get; set; }
        public int EmployeeId { get; set; }
        public int Status { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
