using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeTimetableModel
    {
        public int EmployeeId { get; set; }
        public DateTime AttendedDate { get; set; }
        public string PunchIn { get; set; }
        public string PunchOut { get; set; }
    }
}
