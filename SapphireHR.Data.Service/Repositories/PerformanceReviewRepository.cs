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
            var emp = new PerformanceReview();
            emp.ProffesionalExcellenceSettings =  await _context.Set<ProffesionalExcellenceSettings>().Where(e => e.CompanyId == cmpny.CompanyId).ToListAsync();
            emp.PersonalExcellenceSettings = await _context.Set<PersonalExcellenceSettings>().Where(e => e.CompanyId == cmpny.CompanyId).ToListAsync();
            emp.EmployeeProffesionalExcellence = await _context.Set<EmployeeProffesionalExcellence>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeePersonalExcellence = await _context.Set<EmployeePersonalExcellence>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeeTrainingRequirement = await _context.Set<EmployeeTrainingRequirement>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeeObservation = await _context.Set<EmployeeObservation>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeeInitiativeAchievement = await _context.Set<EmployeeInitiativeAchievement>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeePersonalGoals = await _context.Set<EmployeePersonalGoals>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeeProfGoalAchieved = await _context.Set<EmployeeProfGoalAchieved>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeeProfGoalPlan = await _context.Set<EmployeeProfGoalPlan>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeeRoleComment = await _context.Set<EmployeeRoleComment>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeeResponsibilityComment = await _context.Set<EmployeeResponsibilityComment>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeeHODImprovementComment = await _context.Set<EmployeeHODImprovementComment>().Where(p => p.EmployeeId == emp.Id).ToListAsync();
            emp.EmployeeROImprovementComment = await _context.Set<EmployeeROImprovementComment>().Where(p => p.EmployeeId == emp.Id).ToListAsync();

            return emp;
        }

        public async Task RemovePerformanceReview(int employeeId)
        {
            await _context.FromNoReturnedStoredProcedure("removePerformanceReview", employeeId);
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



        public async Task<ProffesionalExcellenceSettings> GetProffesionalExcellenceSettings(int id)
        {
            return await _context.ProffesionalExcellenceSettings.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<PersonalExcellenceSettings> GetPersonalExcellenceSettings(int id)
        {
            return await _context.PersonalExcellenceSettings.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeePersonalExcellence> GetEmployeePersonalExcellence(int id)
        {
            return await _context.EmployeePersonalExcellences.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeeProffesionalExcellence> GetEmployeeProffesionalExcellence(int id)
        {
            return await _context.EmployeeProffesionalExcellences.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeeTrainingRequirement> GetEmployeeTrainingRequirements(int id)
        {
            return await _context.EmployeeTrainingRequirements.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeeObservation> GetEmployeeObservation(int id)
        {
            return await _context.EmployeeObservations.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeeInitiativeAchievement> GetEmployeeInitiativeAchievement(int id)
        {
            return await _context.EmployeeInitiativeAchievements.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeePersonalGoals> GetEmployeePersonalGoals(int id)
        {
            return await _context.EmployeePersonalGoals.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeeProfGoalAchieved> GetEmployeeProfGoalAchieved(int id)
        {
            return await _context.EmployeeProfGoalAchieveds.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeeProfGoalPlan> GetEmployeeProfGoalPlan(int id)
        {
            return await _context.EmployeeProfGoalPlans.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeeRoleComment> GetEmployeeRoleComment(int id)
        {
            return await _context.EmployeeRoleComments.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeeResponsibilityComment> GetEmployeeResponsibilityComments(int id)
        {
            return await _context.EmployeeResponsibilityComments.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeeHODImprovementComment> GetEmployeeHODImprovementComment(int id)
        {
            return await _context.EmployeeHODImprovementComments.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
        
        public async Task<EmployeeROImprovementComment> GetEmployeeROImprovementComment(int id)
        {
            return await _context.EmployeeROImprovementComments.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        


        public async Task RemoveProffesionalExcellenceSettings(int id)
        {
            var data = await _context.Set<ProffesionalExcellenceSettings>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<ProffesionalExcellenceSettings>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemovePersonalExcellenceSettings(int id)
        {
            var data = await _context.Set<PersonalExcellenceSettings>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<PersonalExcellenceSettings>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeePersonalExcellence(int id)
        {
            var data = await _context.Set<EmployeePersonalExcellence>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeePersonalExcellence>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeeProffesionalExcellence(int id)
        {
            var data = await _context.Set<EmployeeProffesionalExcellence>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeeProffesionalExcellence>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeeTrainingRequirement(int id)
        {
            var data = await _context.Set<EmployeeTrainingRequirement>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeeTrainingRequirement>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeeObservation(int id)
        {
            var data = await _context.Set<EmployeeObservation>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeeObservation>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeeInitiativeAchievement(int id)
        {
            var data = await _context.Set<EmployeeInitiativeAchievement>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeeInitiativeAchievement>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeePersonalGoals(int id)
        {
            var data = await _context.Set<EmployeePersonalGoals>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeePersonalGoals>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeeProfGoalAchieved(int id)
        {
            var data = await _context.Set<EmployeeProfGoalAchieved>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeeProfGoalAchieved>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeeProfGoalPlan(int id)
        {
            var data = await _context.Set<EmployeeProfGoalPlan>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeeProfGoalPlan>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeeRoleComment(int id)
        {
            var data = await _context.Set<EmployeeRoleComment>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeeRoleComment>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeeResponsibilityComment(int id)
        {
            var data = await _context.Set<EmployeeResponsibilityComment>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeeResponsibilityComment>().Remove(data);
            await _context.SaveChangesAsync();
        }
        public async Task RemoveEmployeeHODImprovementComment(int id)
        {
            var data = await _context.Set<EmployeeHODImprovementComment>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeeHODImprovementComment>().Remove(data);
            await _context.SaveChangesAsync();
        }
        
        public async Task RemoveEmployeeROImprovementComment(int id)
        {
            var data = await _context.Set<EmployeeROImprovementComment>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }
            _context.Set<EmployeeROImprovementComment>().Remove(data);
            await _context.SaveChangesAsync();
        }
    }
}
