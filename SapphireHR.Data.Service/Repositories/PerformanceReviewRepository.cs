using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class PerformanceReviewRepository : GenericRepository<PerformanceReview, ApplicationDbContext>
    {
        public PerformanceReviewRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<PerformanceReview> GetPerformance(int id)
        {
            var cmpny = await _context.Set<CompanyEmployee>().FirstOrDefaultAsync(u => u.EmployeeId == id);
            var emp = await _context.Set<PerformanceReview>().Include(n => n.PersonalExcellenceSettings).Include(i => i.ProffesionalExcellenceSettings).FirstOrDefaultAsync(m => m.Id == id);
            emp.ProffesionalExcellenceSettings =  _context.Set<ProffesionalExcellenceSettings>().Where(e => e.CompanyId == cmpny.CompanyId).ToList();
            emp.PersonalExcellenceSettings = _context.Set<PersonalExcellenceSettings>().Where(e => e.CompanyId == cmpny.CompanyId).ToList();
            emp.EmployeeProffesionalExcellence = _context.Set<EmployeeProffesionalExcellence>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeePersonalExcellence = _context.Set<EmployeePersonalExcellence>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeeTrainingRequirement = _context.Set<EmployeeTrainingRequirement>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeeObservation = _context.Set<EmployeeObservation>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeeInitiativeAchievement = _context.Set<EmployeeInitiativeAchievement>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeePersonalGoals = _context.Set<EmployeePersonalGoals>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeeProfGoalAchieved = _context.Set<EmployeeProfGoalAchieved>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeeProfGoalPlan = _context.Set<EmployeeProfGoalPlan>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeeRoleComment = _context.Set<EmployeeRoleComment>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeeResponsibilityComment = _context.Set<EmployeeResponsibilityComment>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeeHODImprovementComment = _context.Set<EmployeeHODImprovementComment>().Where(p => p.EmployeeId == emp.Id).ToList();
            emp.EmployeeROImprovementComment = _context.Set<EmployeeROImprovementComment>().Where(p => p.EmployeeId == emp.Id).ToList();

            return emp;
        }

        public async Task RemovePerformanceReview(int id)
        {
            var data = await _context.Set<PerformanceReview>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<PerformanceReview>().Remove(data);
            await _context.SaveChangesAsync();
        }




        public async Task AddProffesionalExcellenceSettings(ProffesionalExcellenceSettings model)
        {
            _context.Set<ProffesionalExcellenceSettings>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddPersonalExcellenceSettings(PersonalExcellenceSettings model)
        {
            _context.Set<PersonalExcellenceSettings>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeProffesionalExcellence(EmployeeProffesionalExcellence model)
        {
            _context.Set<EmployeeProffesionalExcellence>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeePersonalExcellence(EmployeePersonalExcellence model)
        {
            _context.Set<EmployeePersonalExcellence>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeTrainingRequirement(EmployeeTrainingRequirement model)
        {
            _context.Set<EmployeeTrainingRequirement>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeObservation(EmployeeObservation model)
        {
            _context.Set<EmployeeObservation>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeInitiativeAchievement(EmployeeInitiativeAchievement model)
        {
            _context.Set<EmployeeInitiativeAchievement>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeePersonalGoals(EmployeePersonalGoals model)
        {
            _context.Set<EmployeePersonalGoals>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeProfGoalAchieved(EmployeeProfGoalAchieved model)
        {
            _context.Set<EmployeeProfGoalAchieved>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeProfGoalPlan(EmployeeProfGoalPlan model)
        {
            _context.Set<EmployeeProfGoalPlan>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeRoleComment(EmployeeRoleComment model)
        {
            _context.Set<EmployeeRoleComment>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeResponsibilityComment(EmployeeResponsibilityComment model)
        {
            _context.Set<EmployeeResponsibilityComment>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeHODImprovementComment(EmployeeHODImprovementComment model)
        {
            _context.Set<EmployeeHODImprovementComment>().Add(model);
            await _context.SaveChangesAsync();
        }
        
        public async Task AddEmployeeROImprovementComment(EmployeeROImprovementComment model)
        {
            _context.Set<EmployeeROImprovementComment>().Add(model);
            await _context.SaveChangesAsync();
        }


        



        public async Task UpdateProffesionalExcellenceSettings(ProffesionalExcellenceSettings model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePersonalExcellenceSettings(PersonalExcellenceSettings model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeeProffesionalExcellence(EmployeeProffesionalExcellence model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeePersonalExcellence(EmployeePersonalExcellence model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeeTrainingRequirement(EmployeeTrainingRequirement model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeeObservation(EmployeeObservation model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeeInitiativeAchievement(EmployeeInitiativeAchievement model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeePersonalGoals(EmployeePersonalGoals model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeeProfGoalAchieved(EmployeeProfGoalAchieved model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeeProfGoalPlan(EmployeeProfGoalPlan model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeeRoleComment(EmployeeRoleComment model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeeResponsibilityComment(EmployeeResponsibilityComment model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeeHODImprovementComment(EmployeeHODImprovementComment model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateEmployeeROImprovementComment(EmployeeROImprovementComment model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
