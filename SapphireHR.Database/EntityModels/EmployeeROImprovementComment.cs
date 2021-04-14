using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeROImprovementComment : BaseEntity, IEntity
    {
        public string Strength { get; set; }
        public string AreaOfImprovement { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
