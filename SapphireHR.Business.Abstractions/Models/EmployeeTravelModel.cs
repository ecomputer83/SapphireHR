using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeTravelModel
    {
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public int EmployeeId { get; set; }
        public string MainDestination { get; set; }
        public DateTimeOffset PeriodFrom { get; set; }
        public DateTimeOffset PeriodTo { get; set; }
        public DateTimeOffset DepartureTime { get; set; }
        public string Address { get; set; }
        public string Purpose { get; set; }
        public int CashInAdvance { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
