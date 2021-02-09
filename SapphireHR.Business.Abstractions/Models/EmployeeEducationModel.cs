using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeEducationModel
    {
        public int EmployeeId { get; set; }
        public string Institute { get; set; }
        public string Discipline { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
    }
}
