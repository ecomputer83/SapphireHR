using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeManager : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int ManagerId { get; set; }

        [ForeignKey("EmployeeId")]
        [NotMapped]
        public Employee Employee { get; set; }

        [ForeignKey("ManagerId")]
        public Employee Manager { get; set; }
    }
}
