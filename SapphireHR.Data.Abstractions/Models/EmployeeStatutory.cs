using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class EmployeeStatutory : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string SalaryBasis { get; set; }
        public double SalaryAmount { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
