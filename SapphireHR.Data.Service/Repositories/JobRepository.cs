using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class JobRepository : GenericRepository<JobProfile, ApplicationDbContext>
    {
        public JobRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<List<JobProfile>> GetJobProfiles(int companyId)
        {
            return await _context.Set<JobProfile>().Include(c=>c.Rank).Include(d=>d.Department).Where(c=>c.CompanyId == companyId).ToListAsync();
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


        public async Task<JobProfession> GetJobProfessionbyProfileId(int Id)
        {
            return await _context.Set<JobProfession>().FirstOrDefaultAsync(c => c.JobProfileId == Id);
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

        public async Task<JobRequisition> GetJobRequisitionbyVacancyId(int Id)
        {
            return await _context.Set<JobRequisition>().AsNoTracking().FirstOrDefaultAsync(c => c.VacancyId == Id);
        }
        public async Task<JobRequisition> GetJobRequisitionById(int id)
        {
            return await _context.Set<JobRequisition>().FindAsync(id);
        }
        public async Task AddJobRequisition(JobRequisition model)
        {
            this._context.Set<Database.EntityModels.JobRequisition>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateJobRequisition(JobRequisition model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task RemoveJobRequisition(int id)
        {
            var entity = await _context.Set<JobRequisition>().FindAsync(id);
            if (entity == null)
            {
                await Task.FromException(new Exception("This job requisition doesn't exists"));
            }

            _context.Set<JobRequisition>().Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<List<JobSkillLevel>> GetJobSkillLevels(int profileId)
        {
            return await _context.Set<JobSkillLevel>().Include(s=>s.SkillGrade).Include(s=>s.Skill).ThenInclude(a=>a.SkillType).Where(c=>c.JobProfileId == profileId).ToListAsync();
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


        public async Task<List<Vacancy>> GetVacancies(int id)
        {
            return await _context.Set<Vacancy>().Include(c=>c.JobProfile).Where(c=>c.JobProfile.CompanyId == id).ToListAsync();
        }

        public async Task<List<VacancySummary>> GetVacancySummaries(int companyId)
        {
            var data = await _context.CustomFromSql(@"SELECT 
	v.*,
	j.Title + ' - ' + d.Name as Title,
	(select count(*) from dbo.Applications where VacancyId = v.Id and Status = 0) as NewApplicationCount,
	(select count(*) from dbo.Applications where VacancyId = v.Id and Status = 8) as RejectedApplicationCount,
	(select count(*) from dbo.Applications where VacancyId = v.Id and Status = 1) as AcceptedApplicationCount,
	(select count(*) from dbo.Applications a inner join dbo.ApplicationInterviews i on a.Id = i.ApplicationId where VacancyId = v.Id and a.Status = 2) as PhoneInterviewCount,
	(select count(*) from dbo.Applications a inner join dbo.ApplicationFaceToViews i on a.Id = i.ApplicationId where VacancyId = v.Id and a.Status = 4) as FaceToFaceInterviewCount,
	(select count(*) from dbo.Applications a inner join dbo.ApplicationScores i on a.Id = i.ApplicationId where VacancyId = v.Id and a.Status = 3) as AptitudeTestInterviewCount,
	from dbo.Vacancies v 
	inner join dbo.JobProfiles j on v.JobProfileId = j.Id 
	inner join dbo.Departments d on j.DepartmentId = d.Id
	where j.CompanyId = @p0", companyId);
            var json = JsonConvert.SerializeObject(data);
            return JsonConvert.DeserializeObject<List<VacancySummary>>(json);
        }

        public async Task<Vacancy> GetVacancyApplicationDetail(int vacancyId)
        {
            var data = await _context.Set<Vacancy>().Include(v => v.Vacancysettings).FirstOrDefaultAsync(c => c.Id == vacancyId);
            data.FreshApplications = await _context.Set<Application>().Include(c => c.Applicant).Where(j => j.Status == 0).ToListAsync();
            data.RejectedApplications = await _context.Set<Application>().Include(c => c.Applicant).Include(c=>c.ApplicationInterview).Include(c => c.ApplicationFaceToView).Include(c => c.ApplicationNegotiation).Include(c => c.ApplicationScore).Where(j => j.Status == 8).ToListAsync();
            data.AcceptedApplications = await _context.Set<Application>().Include(c => c.Applicant).Include(c=>c.ApplicationInterview).Include(c => c.ApplicationFaceToView).Include(c => c.ApplicationNegotiation).Include(c => c.ApplicationScore).Where(j => j.Status == 1).ToListAsync();
            data.PhoneInterviewApplications = await _context.Set<Application>().Include(c => c.Applicant).Include(c=>c.ApplicationInterview).Include(c => c.ApplicationFaceToView).Include(c => c.ApplicationNegotiation).Include(c => c.ApplicationScore).Where(j => j.Status == 2).ToListAsync();
            data.FaceToFaceInterviewApplications = await _context.Set<Application>().Include(c => c.Applicant).Include(c=>c.ApplicationInterview).Include(c => c.ApplicationFaceToView).Include(c => c.ApplicationNegotiation).Include(c => c.ApplicationScore).Where(j => j.Status == 3).ToListAsync();
            data.TestInterviewApplications = await _context.Set<Application>().Include(c => c.Applicant).Include(c=>c.ApplicationInterview).Include(c => c.ApplicationFaceToView).Include(c => c.ApplicationNegotiation).Include(c => c.ApplicationScore).Where(j => j.Status == 4).ToListAsync();

            return data;
        }
        public async Task<List<Vacancy>> GetVacanciesByOrgId(int id)
        {
            return await _context.Set<Vacancy>().Include(v=>v.Designation)
                .Include(c => c.JobProfile).ThenInclude(p=>p.Company)
                .Include(v => v.Vacancysettings)
                .Where(c => c.JobProfile.Company.OrganizationId == id)
                .ToListAsync();
        }
        public async Task<Vacancy> GetVacancyById(int id)
        {
            var vacancy = await _context.Set<Vacancy>().Include(v=>v.Vacancysettings).FirstOrDefaultAsync(c=>c.Id == id);
            vacancy.JobRequisition = await GetJobRequisitionbyVacancyId(vacancy.Id);

            return vacancy;
        }
        public async Task<int> AddVacancy(Vacancy model)
        {
            model.JobRequisition = null;
            var data = this._context.Set<Database.EntityModels.Vacancy>().Add(model);
            await _context.SaveChangesAsync();

            return data.Entity.Id;
        }

        public async Task<int> AddVacancySetting(Vacancysettings model)
        {
            var data = this._context.Set<Database.EntityModels.Vacancysettings>().Add(model);
            await _context.SaveChangesAsync();

            return data.Entity.Id;
        }
        public async Task UpdateVacancy(Vacancy model)
        {
            this._context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateVacancysetting(Vacancysettings model)
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
            var setting = await _context.Set<Vacancysettings>().FirstOrDefaultAsync(c => c.VacancyId == entity.Id);
            _context.Set<Vacancysettings>().Remove(setting);
            _context.Set<Vacancy>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
