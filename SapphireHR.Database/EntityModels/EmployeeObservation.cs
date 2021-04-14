using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeObservation : BaseEntity, IEntity
    {
        public string BySelf { get; set; }
        public string ROComment { get; set; }
        public string HODComment { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
