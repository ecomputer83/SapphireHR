using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeStatutoryModel
    {
        public int EmployeeId { get; set; }
        public string SalaryBasis { get; set; }
        public double SalaryAmount { get; set; }
    }
}
