using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Designation : BaseEntity
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
