using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeTimetableModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AttendedDate { get; set; }
        public string Time { get; set; }
        public bool Punch { get; set; }
    }
}
