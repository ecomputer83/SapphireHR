using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeePension : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string PensionNo { get; set; }
        public int EmployeeRate { get; set; }
        public int EmployerRate { get; set; }
        public string PensionManager { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
