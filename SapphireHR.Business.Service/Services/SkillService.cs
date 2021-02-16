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
    public class SkillService : ISkillService
    {

        SkillsRepository _skillRepsitory;
        readonly IMapper _mapper;
        public SkillService(SkillsRepository skillRepsitory, IMapper mapper)
        {
            _skillRepsitory = skillRepsitory;
            _mapper = mapper;
        }
        public async Task AddSkill(SkillModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.Skill>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _skillRepsitory.AddSkill(datamodel);
        }

        public async Task AddSkillType(SkillTypeModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.SkillType>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _skillRepsitory.AddSkillType(datamodel);
        }

        public async Task<SkillModel> GetSkillById(int id)
        {
            var result = await this._skillRepsitory.GetSkillTypeById(id);
            return _mapper.Map<SkillModel>(result);
        }

        public async Task<List<SkillModel>> GetSkills()
        {
            var result = await this._skillRepsitory.GetSkills();
            return _mapper.Map<List<SkillModel>>(result);
        }

        public async Task<SkillTypeModel> GetSkillTypeById(int id)
        {
            var result = await this._skillRepsitory.GetSkillTypeById(id);
            return _mapper.Map<SkillTypeModel>(result);
        }

        public async Task<List<SkillTypeModel>> GetSkillTypes()
        {
            var result = await this._skillRepsitory.GetSkillTypes();
            return _mapper.Map<List<SkillTypeModel>>(result);
        }

        public async Task RemoveSkill(int id)
        {
            await this._skillRepsitory.RemoveSkill(id);

        }

        public async Task RemoveSkillType(int id)
        {
            await this._skillRepsitory.RemoveSkillType(id);
        }

        public async Task UpdateSkill(SkillModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.Skill>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _skillRepsitory.UpdateSkill(datamodel);
        }


        public async Task UpdateSkillType(SkillTypeModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.SkillType>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _skillRepsitory.UpdateSkillType(datamodel);
        }


        public async Task<SkillGradeModel> GetSkillGradeById(int id)
        {
            var result = await this._skillRepsitory.GetSkillGradeById(id);
            return _mapper.Map<SkillGradeModel>(result);
        }

        public async Task<List<SkillGradeModel>> GetSkillGrades()
        {
            var result = await this._skillRepsitory.GetSkillGrades();
            return _mapper.Map<List<SkillGradeModel>>(result);
        }


        public async Task AddSkillGrade(SkillGradeModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.SkillGrade>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _skillRepsitory.AddSkillGrade(datamodel);
        }

        public async Task UpdateSkillGrade(SkillGradeModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.SkillGrade>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _skillRepsitory.UpdateSkillGrade(datamodel);
        }


        public async Task RemoveSkillGrade(int id)
        {
            await this._skillRepsitory.RemoveSkillGrade(id);
        }
    }
}
