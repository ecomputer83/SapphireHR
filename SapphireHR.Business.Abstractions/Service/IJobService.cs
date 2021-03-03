using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IJobService
    {
        Task<List<JobProfileModel>> GetJobProfiles(int companyId);
        Task<JobProfileModel> GetJobProfileById(int Id);
        Task<int> AddJobProfile(JobProfileModel model);
        Task UpdateJobProfile(JobProfileModel model, int Id);
        Task RemoveJobProfile(int id);

        Task<JobProfessionModel> GetJobProfessionByProfileId(int profileId);
        Task<JobProfessionModel> GetJobProfessionById(int Id);
        Task AddJobProfession(JobProfessionModel model);
        Task UpdateJobProfession(JobProfessionModel model, int Id);
        Task RemoveJobProfession(int id);

        Task<JobRequisitionModel> GetJobRequisitionByVacancyId(int vacancyId);
        Task<JobRequisitionModel> GetJobRequisitionById(int Id);
        Task AddJobRequisition(JobRequisitionModel model);
        Task UpdateJobRequisition(JobRequisitionModel model, int Id);
        Task RemoveJobRequisition(int id);


        Task<List<JobSkillLevelModel>> GetJobSkillLevels(int profileId);
        Task<JobSkillLevelModel> GetJobSkillLevelById(int Id);
        Task AddJobSkillLevel(JobSkillLevelModel model);
        Task UpdateJobSkillLevel(JobSkillLevelModel model, int Id);
        Task RemoveJobSkillLevel(int id);


        Task<List<VacancyModel>> GetVacancies(int id);
        Task<List<VacancySummaryModel>> GetVacancySummaries(int id);
        Task<VacancyModel> GetVacancyById(int Id);
        Task<List<VacancyModel>> GetVacanciesByOrgId(int id);
        Task<int> AddVacancy(VacancyModel model);
        Task UpdateVacancy(VacancyModel model, int Id);
        Task RemoveVacancy(int id);
    }
}
