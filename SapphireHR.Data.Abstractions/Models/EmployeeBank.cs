using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class EmployeeBank : BaseEntity
    {
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
