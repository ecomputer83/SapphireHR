using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeTimetable : BaseEntity
    {
        public int EmployeeId { get; set; }
        public DateTime AttendedDate { get; set; }
        public string PunchInTime { get; set; }
        public string PunchOutTime { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
