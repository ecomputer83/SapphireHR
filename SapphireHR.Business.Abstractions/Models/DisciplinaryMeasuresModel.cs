using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class DisciplinaryMeasuresModel
    {
        public DateTime Date { get; set; }
        public string HRManager { get; set; }
        public string Reason { get; set; }
        public string Remark { get; set; }
        public int EmployeeId { get; set; }
    }
}
