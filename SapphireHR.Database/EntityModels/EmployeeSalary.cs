using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeSalary : BaseEntity
    {
        public DateTime SalaryDate { get; set; }
        public double Basic { get; set; }
        public double HRA { get; set; }
        public double MA { get; set; }
        public double PF { get; set; }
        public double Allowance { get; set; }
        public double LeaveAllowance { get; set; }
        public double HMO { get; set; }
        public double Tax { get; set; }
        public double Leave { get; set; }
        public double Others { get; set; }
        public string Reasons { get; set; }
        public double NetSalary { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public virtual SalaryPayment SalaryPayment { get; set; }
        public virtual PensionPayment PensionPayment { get; set; }
        public virtual TaxPayment TaxPayment { get; set; }
    }
}
