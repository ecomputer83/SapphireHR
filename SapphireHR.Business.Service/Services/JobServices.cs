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

        public async Task<int> AddJobProfile(JobProfileModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.JobProfile>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            datamodel = await _jobRepsitory.Add(datamodel);
            return datamodel.Id;
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


        public async Task<int> AddVacancy(VacancyModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.Vacancy>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            var Id = await _jobRepsitory.AddVacancy(datamodel);
            return Id;
        }

        public async Task<JobProfessionModel> GetJobProfessionById(int id)
        {
            var result = await this._jobRepsitory.GetJobProfessionById(id);
            return _mapper.Map<JobProfessionModel>(result);
        }

        public async Task<JobProfessionModel> GetJobProfessionByProfileId(int profileId)
        {
            var result = await this._jobRepsitory.GetJobProfessionbyProfileId(profileId);
            return _mapper.Map<JobProfessionModel>(result);
        }

        public async Task<JobProfileModel> GetJobProfileById(int id)
        {
            var result = await this._jobRepsitory.Get(id);
            return _mapper.Map<JobProfileModel>(result);
        }

        public async Task<List<JobProfileModel>> GetJobProfiles(int companyId)
        {
            var result = await this._jobRepsitory.GetJobProfiles(companyId);
            return _mapper.Map<List<JobProfileModel>>(result);
        }

        public async Task<JobSkillLevelModel> GetJobSkillLevelById(int id)
        {
            var result = await this._jobRepsitory.GetJobSkillLevelById(id);
            return _mapper.Map<JobSkillLevelModel>(result);
        }

        public async Task<List<JobSkillLevelModel>> GetJobSkillLevels(int profileId)
        {
            var result = await this._jobRepsitory.GetJobSkillLevels(profileId);
            return _mapper.Map<List<JobSkillLevelModel>>(result);
        }

        public async Task<List<VacancyModel>> GetVacancies(int id)
        {
            var result = await this._jobRepsitory.GetVacancies(id);
            return _mapper.Map<List<VacancyModel>>(result);
        }

        public async Task<List<VacancySummaryModel>> GetVacancySummaries(int id)
        {
            var result = await this._jobRepsitory.GetVacancySummaries(id);
            return _mapper.Map<List<VacancySummaryModel>>(result);
        }

        public async Task<List<VacancyModel>> GetVacanciesByOrgId(int id)
        {
            var result = await this._jobRepsitory.GetVacanciesByOrgId(id);
            return _mapper.Map<List<VacancyModel>>(result);
        }

        public async Task<VacancyModel> GetVacancyById(int id)
        {
            var result = await this._jobRepsitory.GetVacancyById(id);
            return _mapper.Map<VacancyModel>(result);
        }

        public async Task RemoveJobProfession(int id)
        {
            await this._jobRepsitory.RemoveJobProfession(id);
        }

        public async Task RemoveJobProfile(int id)
        {
            await this._jobRepsitory.Delete(id);
        }

        public async Task RemoveJobSkillLevel(int id)
        {
            await this._jobRepsitory.RemoveJobSkillLevel(id);
        }

        public async Task RemoveVacancy(int id)
        {
            await this._jobRepsitory.RemoveVacancy(id);
        }

        public async Task UpdateJobProfession(JobProfessionModel model, int id)
        {
            var datamodel = _mapper.Map<Database.EntityModels.JobProfession>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.UpdateJobProfession(datamodel);
        }

        public async Task UpdateJobProfile(JobProfileModel model, int id)
        {
            var datamodel = _mapper.Map<Database.EntityModels.JobProfile>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.Update(datamodel);
        }

        public async Task UpdateJobSkillLevel(JobSkillLevelModel model, int id)
        {
            var datamodel = _mapper.Map<Database.EntityModels.JobSkillLevel>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.UpdateJobSkillLevel(datamodel);
        }

        

        public async Task UpdateVacancy(VacancyModel model, int id)
        {
            var datamodel = _mapper.Map<Database.EntityModels.Vacancy>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.UpdateVacancy(datamodel);
        }

        public async Task<JobRequisitionModel> GetJobRequisitionByVacancyId(int vacancyId)
        {
            var result = await this._jobRepsitory.GetJobRequisitionbyVacancyId(vacancyId);
            return _mapper.Map<JobRequisitionModel>(result);
        }

        public async Task<JobRequisitionModel> GetJobRequisitionById(int Id)
        {
            var result = await this._jobRepsitory.GetJobRequisitionById(Id);
            return _mapper.Map<JobRequisitionModel>(result);
        }

        public async Task AddJobRequisition(JobRequisitionModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.JobRequisition>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.AddJobRequisition(datamodel);
        }

        public async Task UpdateJobRequisition(JobRequisitionModel model, int Id)
        {
            var datamodel = _mapper.Map<Database.EntityModels.JobRequisition>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _jobRepsitory.UpdateJobRequisition(datamodel);
        }

        public async Task RemoveJobRequisition(int id)
        {
            await this._jobRepsitory.RemoveJobRequisition(id);
        }
    }
}
