using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeTaxModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Tin { get; set; }
        public string TaxCode { get; set; }
        public string TaxOffice { get; set; }
        //public EmployeeModel Employee { get; set; }
    }
}
