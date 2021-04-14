using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeePersonalExcellence : BaseEntity, IEntity
    {
        public string SelfScore { get; set; }
        public string ROScore { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("PersonalExcellenceSettingId")]
        public int PersonalExcellenceSetting { get; set; }
        public PersonalExcellenceSettings PersonalExcellenceSettings { get; set; }
    }
}
