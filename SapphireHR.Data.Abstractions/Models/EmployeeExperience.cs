using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class EmployeeExperience : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public Employee Employee { get; set; }
    }
}
