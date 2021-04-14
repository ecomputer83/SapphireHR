using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeePersonalGoalsModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string GoalAchieved { get; set; }
        public string GoalSet { get; set; }
    }
}
