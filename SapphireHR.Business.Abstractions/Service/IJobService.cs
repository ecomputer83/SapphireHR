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
        Task UpdateJobProfession(JobProfessionModel model, int Id);
        Task RemoveJobProfession(int id);


        Task<List<JobSkillLevelModel>> GetJobSkillLevels();
        Task<JobSkillLevelModel> GetJobSkillLevelById(int Id);
        Task AddJobSkillLevel(JobSkillLevelModel model);
        Task UpdateJobSkillLevel(JobSkillLevelModel model, int Id);
        Task RemoveJobSkillLevel(int id);


        Task<List<SkillGradeModel>> GetSkillGrades();
        Task<SkillGradeModel> GetSkillGradeById(int Id);
        Task AddSkillGrade(SkillGradeModel model);
        Task UpdateSkillGrade(SkillGradeModel model, int Id);
        Task RemoveSkillGrade(int id);


        Task<List<VacancyModel>> GetVacancies();
        Task<VacancyModel> GetVacancyById(int Id);
        Task AddVacancy(VacancyModel model);
        Task UpdateVacancy(VacancyModel model, int Id);
        Task RemoveVacancy(int id);
    }
}
