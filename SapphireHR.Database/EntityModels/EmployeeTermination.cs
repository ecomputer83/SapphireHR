using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeTermination : BaseEntity
    {
        public DateTimeOffset Date { get; set; }
        public string Reason { get; set; }
        public DateTimeOffset NoticeDate { get; set; }

        public int EmployeeId { get; set; }

        public int TerminationTypeId { get; set; }

        [ForeignKey("TerminationTypeId")]
        public TerminationType TerminationType { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

    }
}
