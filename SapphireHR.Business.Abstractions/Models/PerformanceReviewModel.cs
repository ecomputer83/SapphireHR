using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class PerformanceReviewModel
    {
        public int Id { get; set; }
        public ProffesionalExcellenceSettingsModel ProffesionalExcellenceSettings { get; set; }
        public EmployeeProffesionalExcellenceModel EmployeeProffesionalExcellence { get; set; }
        public EmployeePersonalExcellenceModel EmployeePersonalExcellence { get; set; }
        public PersonalExcellenceSettingsModel PersonalExcellenceSettings { get; set; }
        public EmployeeTrainingRequirementModel EmployeeTrainingRequirement { get; set; }
        public EmployeeObservationModel EmployeeObservation { get; set; }
        public EmployeeInitiativeAchievementModel EmployeeInitiativeAchievement { get; set; }
        public EmployeePersonalGoalsModel EmployeePersonalGoals { get; set; }
        public EmployeeProfGoalAchievedModel EmployeeProfGoalAchieved { get; set; }
        public EmployeeProfGoalPlanModel EmployeeProfGoalPlan { get; set; }
        public EmployeeRoleCommentModel EmployeeRoleComment { get; set; }
        public EmployeeResponsibilityCommentModel EmployeeResponsibilityComment { get; set; }
        public EmployeeHODImprovementCommentModel EmployeeHODImprovementComment { get; set; }
        public EmployeeROImprovementCommentModel EmployeeROImprovementComment { get; set; }
    }
}
