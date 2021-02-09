using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeExperienceModel
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
    }
}
