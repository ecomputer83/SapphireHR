using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeExperience : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
