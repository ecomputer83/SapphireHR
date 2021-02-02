using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeEducation : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string Institute { get; set; }
        public string Discipline { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
