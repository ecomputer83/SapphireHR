using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Data.Service.Repositories;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class PerformanceReviewServices : IPerformanceReviewService
    {
        private readonly IMapper _mapper;
        private readonly PerformanceReviewRepository _performanceReview;

        public PerformanceReviewServices(IMapper mapper, PerformanceReviewRepository performanceReview)
        {
            _mapper = mapper;
            _performanceReview = performanceReview;
        }

        public async Task AddProffesionalExcellenceSettings(ProffesionalExcellenceSettingsModel model)
        {
            var datamodel = _mapper.Map<ProffesionalExcellenceSettings>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddProffesionalExcellenceSettings(datamodel);
        }
        
        public async Task AddPersonalExcellenceSettings(PersonalExcellenceSettingsModel model)
        {
            var datamodel = _mapper.Map<PersonalExcellenceSettings>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddPersonalExcellenceSettings(datamodel);
        }
        
        public async Task AddEmployeeProffesionalExcellence(EmployeeProffesionalExcellenceModel model)
        {
            var datamodel = _mapper.Map<EmployeeProffesionalExcellence>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeeProffesionalExcellence(datamodel);
        }
        
        public async Task AddEmployeePersonalExcellence(EmployeePersonalExcellenceModel model)
        {
            var datamodel = _mapper.Map<EmployeePersonalExcellence>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeePersonalExcellence(datamodel);
        }
        
        public async Task AddEmployeeTrainingRequirement(EmployeeTrainingRequirementModel model)
        {
            var datamodel = _mapper.Map<EmployeeTrainingRequirement>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeeTrainingRequirement(datamodel);
        }
        
        public async Task AddEmployeeObservation(EmployeeObservationModel model)
        {
            var datamodel = _mapper.Map<EmployeeObservation>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeeObservation(datamodel);
        }
        
        public async Task AddEmployeeInitiativeAchievement(EmployeeInitiativeAchievementModel model)
        {
            var datamodel = _mapper.Map<EmployeeInitiativeAchievement>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeeInitiativeAchievement(datamodel);
        }
        
        public async Task AddEmployeePersonalGoals(EmployeePersonalGoalsModel model)
        {
            var datamodel = _mapper.Map<EmployeePersonalGoals>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeePersonalGoals(datamodel);
        }
        
        public async Task AddEmployeeProfGoalAchieved(EmployeeProfGoalAchievedModel model)
        {
            var datamodel = _mapper.Map<EmployeeProfGoalAchieved>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeeProfGoalAchieved(datamodel);
        }
        
        public async Task AddEmployeeProfGoalPlan(EmployeeProfGoalPlanModel model)
        {
            var datamodel = _mapper.Map<EmployeeProfGoalPlan>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeeProfGoalPlan(datamodel);
        } 
        
        public async Task AddEmployeeRoleComment(EmployeeRoleCommentModel model)
        {
            var datamodel = _mapper.Map<EmployeeRoleComment>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeeRoleComment(datamodel);
        } 
        
        public async Task AddEmployeeResponsibilityComment(EmployeeResponsibilityCommentModel model)
        {
            var datamodel = _mapper.Map<EmployeeResponsibilityComment>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeeResponsibilityComment(datamodel);
        } 
        
        public async Task AddEmployeeHODImprovementComment(EmployeeHODImprovementCommentModel model)
        {
            var datamodel = _mapper.Map<EmployeeHODImprovementComment>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeeHODImprovementComment(datamodel);
        }
        
        public async Task AddEmployeeROImprovementComment(EmployeeROImprovementCommentModel model)
        {
            var datamodel = _mapper.Map<EmployeeROImprovementComment>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _performanceReview.AddEmployeeROImprovementComment(datamodel);
        }




        

        public async Task UpdateProffesionalExcellenceSettings(ProffesionalExcellenceSettingsModel model, int id)
        {
            var data = await _performanceReview.GetProffesionalExcellenceSettings(id);
            data.Weightage = model.Weightage;
            data.KeyResult = model.KeyResult;
            data.KeyPerfomanceIndicator = model.KeyPerfomanceIndicator;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateProffesionalExcellenceSettings(data);
        }
        
        public async Task UpdatePersonalExcellenceSettings(PersonalExcellenceSettingsModel model, int id)
        {
            var data = await _performanceReview.GetPersonalExcellenceSettings(id);
            data.Weightage = model.Weightage;
            data.KeyResult = model.KeyResult;
            data.KeyPerfomanceIndicator = model.KeyPerfomanceIndicator;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdatePersonalExcellenceSettings(data);
        }
        
        public async Task UpdateEmployeePersonalExcellence(EmployeePersonalExcellenceModel model, int id)
        {
            var data = await _performanceReview.GetEmployeePersonalExcellence(id);
            data.ROScore = model.ROScore;
            data.SelfScore = model.SelfScore;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeePersonalExcellence(data);
        } 
        
        public async Task UpdateEmployeeProffesionalExcellence(EmployeeProffesionalExcellenceModel model, int id)
        {
            var data = await _performanceReview.GetEmployeeProffesionalExcellence(id);
            data.ROScore = model.ROScore;
            data.SelfScore = model.SelfScore;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeeProffesionalExcellence(data);
        }
        
        public async Task UpdateEmployeeTrainingRequirement(EmployeeTrainingRequirementModel model, int id)
        {
            var data = await _performanceReview.GetEmployeeTrainingRequirements(id);
            data.BySelf = model.BySelf;
            data.HODComment = model.HODComment;
            data.ROComment = model.ROComment;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeeTrainingRequirement(data);
        }
        
        public async Task UpdateEmployeeObservation(EmployeeObservationModel model, int id)
        {
            var data = await _performanceReview.GetEmployeeObservation(id);
            data.BySelf = model.BySelf;
            data.HODComment = model.HODComment;
            data.ROComment = model.ROComment;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeeObservation(data);
        }
        
        public async Task UpdateEmployeeInitiativeAchievement(EmployeeInitiativeAchievementModel model, int id)
        {
            var data = await _performanceReview.GetEmployeeInitiativeAchievement(id);
            data.BySelf = model.BySelf;
            data.HODComment = model.HODComment;
            data.ROComment = model.ROComment;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeeInitiativeAchievement(data);
        }
        
        public async Task UpdatEmployeePersonalGoals(EmployeePersonalGoalsModel model, int id)
        {
            var data = await _performanceReview.GetEmployeePersonalGoals(id);
            data.GoalAchieved = model.GoalAchieved;
            data.GoalSet = model.GoalSet;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeePersonalGoals(data);
        }
        
        public async Task UpdateEmployeeProfGoalAchieved(EmployeeProfGoalAchievedModel model, int id)
        {
            var data = await _performanceReview.GetEmployeeProfGoalAchieved(id);
            data.Year = model.Year;
            data.ROComment = model.ROComment;
            data.HODComment = model.HODComment;
            data.BySelf = model.BySelf;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeeProfGoalAchieved(data);
        }
        
        public async Task UpdateEmployeeProfGoalPlan(EmployeeProfGoalPlanModel model, int id)
        {
            var data = await _performanceReview.GetEmployeeProfGoalPlan(id);
            data.Year = model.Year;
            data.ROComment = model.ROComment;
            data.HODComment = model.HODComment;
            data.BySelf = model.BySelf;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeeProfGoalPlan(data);
        }
        
        public async Task UpdateEmployeeRoleComment(EmployeeRoleCommentModel model, int id)
        {
            var data = await _performanceReview.GetEmployeeRoleComment(id);
            data.BySelf = model.BySelf;
            data.HODComment = model.HODComment;
            data.ROComment = model.ROComment;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeeRoleComment(data);
        }
        
        public async Task UpdateEmployeeResponsibilityComment(EmployeeResponsibilityCommentModel model, int id)
        {
            var data = await _performanceReview.GetEmployeeResponsibilityComments(id);
            data.AreaOfImprovement = model.AreaOfImprovement;
            data.Strength = model.Strength;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeeResponsibilityComment(data);
        }
        
        public async Task UpdateEmployeeHODImprovementComment(EmployeeHODImprovementCommentModel model, int id)
        {
            var data = await _performanceReview.GetEmployeeHODImprovementComment(id);
            data.AreaOfImprovement = model.AreaOfImprovement;
            data.Strength = model.Strength;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeeHODImprovementComment(data);
        }
        
        public async Task UpdateEmployeeROImprovementComment(EmployeeROImprovementCommentModel model, int id)
        {
            var data = await _performanceReview.GetEmployeeROImprovementComment(id);
            data.AreaOfImprovement = model.AreaOfImprovement;
            data.Strength = model.Strength;
            data.UpdatedAt = DateTime.Now;
            data.UpdatedBy = "SYSTEM";
            await _performanceReview.UpdateEmployeeROImprovementComment(data);
        }




        public async Task RemovePersonalExcellenceSettings(int id)
        {
            await _performanceReview.RemovePersonalExcellenceSettings(id);
        }
        
        public async Task RemoveProffesionalExcellenceSett(int id)
        {
            await _performanceReview.RemoveProffesionalExcellenceSettings(id);
        }
        
        public async Task RemoveEmployeePersonalExcellence(int id)
        {
            await _performanceReview.RemoveEmployeePersonalExcellence(id);
        }
        
        public async Task RemoveEmployeeProffesionalExcellence(int id)
        {
            await _performanceReview.RemoveEmployeeProffesionalExcellence(id);
        }
        
        public async Task RemoveEmployeeTrainingRequirement(int id)
        {
            await _performanceReview.RemoveEmployeeTrainingRequirement(id);
        }
        
        public async Task RemoveEmployeeObservation(int id)
        {
            await _performanceReview.RemoveEmployeeObservation(id);
        }
        
        public async Task RemoveEmployeeInitiativeAchievement(int id)
        {
            await _performanceReview.RemoveEmployeeInitiativeAchievement(id);
        }
        
        public async Task RemoveEmployeePersonalGoals(int id)
        {
            await _performanceReview.RemoveEmployeePersonalGoals(id);
        }
        
        public async Task RemoveEmployeeProfGoalAchieved(int id)
        {
            await _performanceReview.RemoveEmployeeProfGoalAchieved(id);
        }
        
        public async Task RemoveEmployeeProfGoalPlan(int id)
        {
            await _performanceReview.RemoveEmployeeProfGoalPlan(id);
        }
        
        public async Task RemoveEmployeeRoleComment(int id)
        {
            await _performanceReview.RemoveEmployeeRoleComment(id);
        }
        
        public async Task RemoveEmployeeResponsibilityComment(int id)
        {
            await _performanceReview.RemoveEmployeeResponsibilityComment(id);
        }
        
        public async Task RemoveEmployeeHODImprovementComment(int id)
        {
            await _performanceReview.RemoveEmployeeHODImprovementComment(id);
        }
        
        public async Task RemoveEmployeeROImprovementComment(int id)
        {
            await _performanceReview.RemoveEmployeeROImprovementComment(id);
        }



    }
}
