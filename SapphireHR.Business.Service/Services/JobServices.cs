using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Data.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class JobServices : IJobService
    {
        JobRepository _jobRepsitory;
        readonly IMapper _mapper;
        public JobServices(JobRepository jobRepsitory, IMapper mapper)
        {
            _jobRepsitory = jobRepsitory;
            _mapper = mapper;
        }
        public async Task AddJobProfession(JobProfessionModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.JobProfession>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.AddJobProfession(datamodel);
        }

        public async Task AddJobProfile(JobProfileModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.JobProfile>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.Add(datamodel);
        }

        public async Task AddJobSkillLevel(JobSkillLevelModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.JobSkillLevel>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.AddJobSkillLevel(datamodel);
        }

        public async Task AddSkillGrade(SkillGradeModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.SkillGrade>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.AddSkillGrade(datamodel);
        }

        public async Task AddVacancy(VacancyModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.Vacancy>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.AddVacancy(datamodel);
        }

        public async Task<JobProfessionModel> GetJobProfessionById(int Id)
        {
            var ranks = await this._jobRepsitory.GetJobProfessionById(Id);
            return _mapper.Map<JobProfessionModel>(ranks);
        }

        public async Task<List<JobProfessionModel>> GetJobProfessions()
        {
            var ranks = await this._jobRepsitory.GetJobProfessions();
            return _mapper.Map<List<JobProfessionModel>>(ranks);
        }

        public async Task<JobProfileModel> GetJobProfileById(int Id)
        {
            var ranks = await this._jobRepsitory.Get(Id);
            return _mapper.Map<JobProfileModel>(ranks);
        }

        public async Task<List<JobProfileModel>> GetJobProfiles()
        {
            var ranks = await this._jobRepsitory.GetAll();
            return _mapper.Map<List<JobProfileModel>>(ranks);
        }

        public async Task<JobSkillLevelModel> GetJobSkillLevelById(int Id)
        {
            var ranks = await this._jobRepsitory.GetJobSkillLevelById(Id);
            return _mapper.Map<JobSkillLevelModel>(ranks);
        }

        public async Task<List<JobSkillLevelModel>> GetJobSkillLevels()
        {
            var ranks = await this._jobRepsitory.GetJobSkillLevels();
            return _mapper.Map<List<JobSkillLevelModel>>(ranks);
        }

        public async Task<List<SkillGradeModel>> GetSkillGradeById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task GetSkillGrades()
        {
            throw new NotImplementedException();
        }

        public Task GetVacancies()
        {
            throw new NotImplementedException();
        }

        public Task GetVacancyById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveJobProfession(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveJobProfile(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveJobSkillLevel(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSkillGrade(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveVacancy(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateJobProfession(JobProfessionModel model, int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateJobProfile(JobProfileModel model, int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateJobSkillLevel(JobSkillLevelModel model, int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSkillGrade(SkillGradeModel model, int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateVacancy(VacancyModel model, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
