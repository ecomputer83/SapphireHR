using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class EmployeeFamily : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string PhoneNo { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
