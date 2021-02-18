using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeTravel : BaseEntity
    {
        public string MainDestination { get; set; }
        public DateTimeOffset PeriodFrom { get; set; }
        public DateTimeOffset PeriodTo { get; set; }
        public DateTimeOffset DepartureTime { get; set; }
        public string Address { get; set; }
        public string Purpose { get; set; }
        public int CashInAdvance { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
