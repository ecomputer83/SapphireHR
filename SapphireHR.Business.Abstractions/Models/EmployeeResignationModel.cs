using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeResignationModel
    {
        public int Id { get; set; }
        public DateTime NoticeDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public string Reason { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
