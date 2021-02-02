using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeTimetable : BaseEntity
    {
        public int EmployeeId { get; set; }
        public DateTime AttendedDate { get; set; }
        public string PunchIn { get; set; }
        public string PunchOut { get; set; }
    }
}
