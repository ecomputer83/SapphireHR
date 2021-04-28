﻿using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IPerformanceReviewService
    {
        Task<List<PerformanceReviewModel>> GetPerformanceReview(int Id);
        Task<List<PersonalExcellenceSettingsModel>> GetPersonalExcellenceSettings(int Id);
        Task<List<ProffesionalExcellenceSettingsModel>> GetProffesionalExcellenceSettings(int Id);
        Task<List<EmployeePersonalExcellenceModel>> GetEmployeePersonalExcellence(int Id);
        Task<List<EmployeeProffesionalExcellenceModel>> GetEmployeeProffesionalExcellence(int Id);
        Task<List<EmployeeTrainingRequirementModel>> GetEmployeeTrainingRequirement(int Id);
        Task<List<EmployeeObservationModel>> GetEmployeeObservation(int Id);
        Task<List<EmployeeInitiativeAchievementModel>> GetEmployeeInitiativeAchievement(int Id);
        Task<List<EmployeePersonalGoalsModel>> GetEmployeePersonalGoals(int Id);
        Task<List<EmployeeProfGoalAchievedModel>> GetEmployeeProfGoalAchieved(int Id);
        Task<List<EmployeeProfGoalPlanModel>> GetEmployeeProfGoalPlan(int Id);
        Task<List<EmployeeRoleCommentModel>> GetEmployeeRoleComment(int Id);
        Task<List<EmployeeResponsibilityCommentModel>> GetEmployeeResponsibilityComment(int Id);
        Task<List<EmployeeHODImprovementCommentModel>> GetEmployeeHODImprovementComment(int Id);
        Task<List<EmployeeROImprovementCommentModel>> GetEmployeeROImprovementComment(int Id);




        Task AddProffesionalExcellenceSettings(ProffesionalExcellenceSettingsModel model);
        Task AddPersonalExcellenceSettings(PersonalExcellenceSettingsModel model);
        Task AddEmployeeProffesionalExcellence(EmployeeProffesionalExcellenceModel model);
        Task AddEmployeePersonalExcellence(EmployeePersonalExcellenceModel model);
        Task AddEmployeeTrainingRequirement(EmployeeTrainingRequirementModel model);
        Task AddEmployeeObservation(EmployeeObservationModel model);
        Task AddEmployeeInitiativeAchievement(EmployeeInitiativeAchievementModel model);
        Task AddEmployeePersonalGoals(EmployeePersonalGoalsModel model);
        Task AddEmployeeProfGoalAchieved(EmployeeProfGoalAchievedModel model);
        Task AddEmployeeProfGoalPlan(EmployeeProfGoalPlanModel model);
        Task AddEmployeeRoleComment(EmployeeRoleCommentModel model);
        Task AddEmployeeResponsibilityComment(EmployeeResponsibilityCommentModel model);
        Task AddEmployeeHODImprovementComment(EmployeeHODImprovementCommentModel model);
        Task AddEmployeeROImprovementComment(EmployeeROImprovementCommentModel model);



        Task UpdateProffesionalExcellenceSettings(ProffesionalExcellenceSettingsModel model, int id);
        Task UpdatePersonalExcellenceSettings(PersonalExcellenceSettingsModel model, int id);
        Task UpdateEmployeePersonalExcellence(EmployeePersonalExcellenceModel model, int id);
        Task UpdateEmployeeProffesionalExcellence(EmployeeProffesionalExcellenceModel model, int id);
        Task UpdateEmployeeTrainingRequirement(EmployeeTrainingRequirementModel model, int id);
        Task UpdateEmployeeObservation(EmployeeObservationModel model, int id);
        Task UpdateEmployeeInitiativeAchievement(EmployeeInitiativeAchievementModel model, int id);
        Task UpdatEmployeePersonalGoals(EmployeePersonalGoalsModel model, int id);
        Task UpdateEmployeeProfGoalAchieved(EmployeeProfGoalAchievedModel model, int id);
        Task UpdateEmployeeProfGoalPlan(EmployeeProfGoalPlanModel model, int id);
        Task UpdateEmployeeRoleComment(EmployeeRoleCommentModel model, int id);
        Task UpdateEmployeeResponsibilityComment(EmployeeResponsibilityCommentModel model, int id);
        Task UpdateEmployeeHODImprovementComment(EmployeeHODImprovementCommentModel model, int id);
        Task UpdateEmployeeROImprovementComment(EmployeeROImprovementCommentModel model, int id);




        Task RemovePerformanceReview(int id);
        Task RemovePersonalExcellenceSettings(int id);
        Task RemoveProffesionalExcellenceSettings(int id);
        Task RemoveEmployeePersonalExcellence(int id);
        Task RemoveEmployeeProffesionalExcellence(int id);
        Task RemoveEmployeeTrainingRequirement(int id);
        Task RemoveEmployeeObservation(int id);
        Task RemoveEmployeeInitiativeAchievement(int id);
        Task RemoveEmployeePersonalGoals(int id);
        Task RemoveEmployeeProfGoalAchieved(int id);
        Task RemoveEmployeeProfGoalPlan(int id);
        Task RemoveEmployeeRoleComment(int id);
        Task RemoveEmployeeResponsibilityComment(int id);
        Task RemoveEmployeeHODImprovementComment(int id);
        Task RemoveEmployeeROImprovementComment(int id);
    }
}