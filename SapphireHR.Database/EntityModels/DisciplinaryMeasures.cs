using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class DisciplinaryMeasures : BaseEntity, IEntity
    {
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string HRManager { get; set; }
        public string Reason { get; set; }
        public string Remark { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
