
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeePersonalGoals : BaseEntity, IEntity
    {
        public string GoalAchieved { get; set; }
        public string GoalSet { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
