using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeTax : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string Tin { get; set; }
        public string TaxCode { get; set; }
        public string TaxOffice { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
