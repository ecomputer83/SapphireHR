using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeTerminationModel
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Reason { get; set; }
        public DateTimeOffset NoticeDate { get; set; }
        public int TerminationTypeId { get; set; }
        public TerminationTypeModel TerminationType { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
