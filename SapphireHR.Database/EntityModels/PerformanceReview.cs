using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class PerformanceReview : BaseEntity, IEntity
    {
        public virtual List<ProffesionalExcellenceSettings> ProffesionalExcellenceSettings { get; set; }
        public virtual List<PersonalExcellenceSettings> PersonalExcellenceSettings { get; set; }
        public virtual List<EmployeeProffesionalExcellence> EmployeeProffesionalExcellence{ get; set; }
        public virtual List<EmployeePersonalExcellence> EmployeePersonalExcellence{ get; set; }
        public virtual List<EmployeeTrainingRequirement> EmployeeTrainingRequirement { get; set; }
        public virtual List<EmployeeObservation> EmployeeObservation { get; set; }
        public virtual List<EmployeeInitiativeAchievement> EmployeeInitiativeAchievement { get; set; }
        public virtual List<EmployeePersonalGoals> EmployeePersonalGoals { get; set; }
        public virtual List<EmployeeProfGoalAchieved> EmployeeProfGoalAchieved { get; set; }
        public virtual List<EmployeeProfGoalPlan> EmployeeProfGoalPlan { get; set; }
        public virtual List<EmployeeRoleComment> EmployeeRoleComment { get; set; }
        public virtual List<EmployeeResponsibilityComment> EmployeeResponsibilityComment { get; set; }
        public virtual List<EmployeeHODImprovementComment> EmployeeHODImprovementComment { get; set; }
        public virtual List<EmployeeROImprovementComment> EmployeeROImprovementComment { get; set; }
    }
}
