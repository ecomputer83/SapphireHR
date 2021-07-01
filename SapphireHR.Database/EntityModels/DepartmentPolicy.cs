using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class DepartmentPolicy : BaseEntity, IEntity
    { 
        
        public int DepartmentId { get; set; }
        public int PolicyId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        [ForeignKey("PolicyId")]
        public Policy Policy { get; set; }
    }
}
