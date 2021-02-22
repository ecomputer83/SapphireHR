using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;

namespace SapphireHR.Data.Service.Repositories
{
    public class SkillsRepository : GenericRepository<Skill, ApplicationDbContext>
    {
        public SkillsRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Skill>> GetSkills(int companyId)
        {
            return await _context.Set<Skill>().Include(s=>s.SkillType).Where(c=>c.CompanyId == companyId).ToListAsync();
        }
        public async Task<Skill> GetSkillById(int id)
        {
            return await _context.Skills.AsNoTracking().FirstOrDefaultAsync(s=>s.Id == id);
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


        public async Task<List<SkillType>> GetSkillTypes(int companyId)
        {
            return await _context.Set<SkillType>().Where(c => c.CompanyId == companyId).ToListAsync();
        }
        public async Task<SkillType> GetSkillTypeById(int id)
        {
            return await _context.SkillTypes.AsNoTracking().FirstOrDefaultAsync(s => s.Id == id);
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


        public async Task<List<SkillGrade>> GetSkillGrades(int companyId)
        {
            return await _context.Set<SkillGrade>().Where(c => c.CompanyId == companyId).ToListAsync();
        }
        public async Task<SkillGrade> GetSkillGradeById(int id)
        {
            return await _context.SkillGrades.AsNoTracking().Where(c => c.Id == id).FirstOrDefaultAsync();
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
    }
}
