using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface ISkillService
    {
        Task<List<SkillModel>> GetSkills(int CompanyId);
        Task<SkillModel> GetSkillById(int id);
        Task AddSkill(SkillModel model);
        Task UpdateSkill(SkillModel model);
        Task RemoveSkill(int id);



        Task<List<SkillTypeModel>> GetSkillTypes(int CompanyId);
        Task<SkillTypeModel> GetSkillTypeById(int id);
        Task AddSkillType(SkillTypeModel model);
        Task UpdateSkillType(SkillTypeModel model);
        Task RemoveSkillType(int id);


        Task<List<SkillGradeModel>> GetSkillGrades(int CompanyId);
        Task<SkillGradeModel> GetSkillGradeById(int id);
        Task AddSkillGrade(SkillGradeModel model);
        Task UpdateSkillGrade(SkillGradeModel model);
        Task RemoveSkillGrade(int id);
    }
}
