using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IJobService
    {
        Task<List<JobProfileModel>> GetJobProfiles();
        Task<JobProfileModel> GetJobProfileById(int Id);
        Task AddJobProfile(JobProfileModel model);
        Task UpdateJobProfile(JobProfileModel model, int Id);
        Task RemoveJobProfile(int id);

        Task<List<JobProfessionModel>> GetJobProfessions();
        Task<JobProfessionModel> GetJobProfessionById(int Id);
        Task AddJobProfession(JobProfessionModel model);
        Task<JobProfileModel> UpdateJobProfession(JobProfessionModel model, int Id);
        Task RemoveJobProfession(int id);


        Task<List<JobSkillLevelModel>> GetJobSkillLevels();
        Task<JobSkillLevelModel> GetJobSkillLevelById(int Id);
        Task<JobProfileModel> AddJobSkillLevel(JobSkillLevelModel model);
        Task<JobProfileModel> UpdateJobSkillLevel(JobSkillLevelModel model, int Id);
        Task RemoveJobSkillLevel(int id);


        Task<List<SkillGradeModel>> GetSkillGrades();
        Task<SkillGradeModel> GetSkillGradeById(int Id);
        Task<JobProfileModel> AddSkillGrade(SkillGradeModel model);
        Task<JobProfileModel> UpdateSkillGrade(SkillGradeModel model, int Id);
        Task RemoveSkillGrade(int id);


        Task<List<VacancyModel>> GetVacancies();
        Task<VacancyModel> GetVacancyById(int Id);
        Task<JobProfileModel> AddVacancy(VacancyModel model);
        Task<JobProfileModel> UpdateVacancy(VacancyModel model, int Id);
        Task RemoveVacancy(int id);
    }
}
