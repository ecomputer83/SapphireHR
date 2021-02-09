using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class JobRepository : GenericRepository<JobProfile, ApplicationDbContext>
    {
        public JobRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<List<JobCategory>> GetJobCategories()
        {
            return await _context.Set<JobCategory>().ToListAsync();
        }
        public async Task<JobCategory> GetJobCategoryById(int id)
        {
            return await _context.Set<JobCategory>().FindAsync(id);
        }
        public async Task AddJobCategory(JobCategory model)
        {
            this._context.Set<Database.EntityModels.JobCategory>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateJobCategory(JobCategory model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task RemoveJobCategory(int id)
        {
            var entity = await _context.Set<JobCategory>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("This job category doesn't exists"));
            }

            _context.Set<JobCategory>().Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<List<JobProfession>> GetJobProfessions()
        {
            return await _context.Set<JobProfession>().ToListAsync();
        }
        public async Task<JobProfession> GetJobProfessionById(int id)
        {
            return await _context.Set<JobProfession>().FindAsync(id);
        }
        public async Task AddJobProfession(JobProfession model)
        {
            this._context.Set<Database.EntityModels.JobProfession>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateJobProfession(JobProfession model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task RemoveJobProfession(int id)
        {
            var entity = await _context.Set<JobProfession>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("This job profession doesn't exists"));
            }

            _context.Set<JobProfession>().Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<List<JobSkillLevel>> GetJobSkillLevels()
        {
            return await _context.Set<JobSkillLevel>().ToListAsync();
        }
        public async Task<JobSkillLevel> GetJobSkillLevelById(int id)
        {
            return await _context.Set<JobSkillLevel>().FindAsync(id);
        }
        public async Task AddJobSkillLevel(JobSkillLevel model)
        {
            this._context.Set<Database.EntityModels.JobSkillLevel>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateJobSkillLevel(JobSkillLevel model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task RemoveJobSkillLevel(int id)
        {
            var entity = await _context.Set<JobSkillLevel>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("This job skill level doesn't exists"));
            }

            _context.Set<JobSkillLevel>().Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<List<Skill>> GetSkills()
        {
            return await _context.Set<Skill>().ToListAsync();
        }
        public async Task<Skill> GetSkillById(int id)
        {
            return await _context.Set<Skill>().FindAsync(id);
        }
        public async Task AddSkill(Skill model)
        {
            this._context.Set<Database.EntityModels.Skill>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateSkill(Skill model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task RemoveSkill(int id)
        {
            var entity = await _context.Set<Skill>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("This skill doesn't exists"));
            }

            _context.Set<Skill>().Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<List<SkillType>> GetSkillTypes()
        {
            return await _context.Set<SkillType>().ToListAsync();
        }
        public async Task<SkillType> GetSkillTypeById(int id)
        {
            return await _context.Set<SkillType>().FindAsync(id);
        }
        public async Task AddSkillType(SkillType model)
        {
            this._context.Set<Database.EntityModels.SkillType>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateSkillType(SkillType model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task RemoveSkillType(int id)
        {
            var entity = await _context.Set<SkillType>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("This skill doesn't exists"));
            }

            _context.Set<SkillType>().Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<List<SkillGrade>> GetSkillGrades()
        {
            return await _context.Set<SkillGrade>().ToListAsync();
        }
        public async Task<SkillGrade> GetSkillGradeById(int id)
        {
            return await _context.Set<SkillGrade>().FindAsync(id);
        }
        public async Task AddSkillGrade(SkillGrade model)
        {
            this._context.Set<Database.EntityModels.SkillGrade>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateSkillGrade(SkillGrade model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task RemoveSkillGrade(int id)
        {
            var entity = await _context.Set<SkillGrade>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("This skill grade doesn't exists"));
            }

            _context.Set<SkillGrade>().Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<List<Vacancy>> GetVacancies()
        {
            return await _context.Set<Vacancy>().ToListAsync();
        }
        public async Task<Vacancy> GetVacancyById(int id)
        {
            return await _context.Set<Vacancy>().FindAsync(id);
        }
        public async Task AddVacancy(Vacancy model)
        {
            this._context.Set<Database.EntityModels.Vacancy>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateVacancy(Vacancy model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task RemoveVacancy(int id)
        {
            var entity = await _context.Set<Vacancy>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("This vacancy doesn't exists"));
            }

            _context.Set<Vacancy>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
