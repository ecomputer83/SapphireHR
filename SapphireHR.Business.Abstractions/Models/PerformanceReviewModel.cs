using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class PerformanceReviewModel
    {
        public int Id { get; set; }
        public virtual ProffesionalExcellenceSettingsModel ProffesionalExcellenceSettings { get; set; }
        public virtual EmployeeProffesionalExcellenceModel EmployeeProffesionalExcellence { get; set; }
        public virtual EmployeePersonalExcellenceModel EmployeePersonalExcellence { get; set; }
        public virtual PersonalExcellenceSettingsModel PersonalExcellenceSettings { get; set; }
        public virtual EmployeeTrainingRequirementModel EmployeeTrainingRequirement { get; set; }
        public virtual EmployeeObservationModel EmployeeObservation { get; set; }
        public virtual EmployeeInitiativeAchievementModel EmployeeInitiativeAchievement { get; set; }
        public virtual EmployeePersonalGoalsModel EmployeePersonalGoals { get; set; }
        public virtual EmployeeProfGoalAchievedModel EmployeeProfGoalAchieved { get; set; }
        public virtual EmployeeProfGoalPlanModel EmployeeProfGoalPlan { get; set; }
        public virtual EmployeeRoleCommentModel EmployeeRoleComment { get; set; }
        public virtual EmployeeResponsibilityCommentModel EmployeeResponsibilityComment { get; set; }
        public virtual EmployeeHODImprovementCommentModel EmployeeHODImprovementComment { get; set; }
        public virtual EmployeeROImprovementCommentModel EmployeeROImprovementComment { get; set; }
    }
}
