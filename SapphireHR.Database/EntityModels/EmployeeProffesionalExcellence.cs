using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeProffesionalExcellence : BaseEntity, IEntity
    {

        public int SelfScore { get; set; }
        public int ROScore { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("ProffesionalExcellenceSettingsId")]
        public int ProffesionalExcellenceSettingsId { get; set; }
        public ProffesionalExcellenceSettings ProffesionalExcellenceSettings { get; set; }
    }
}
