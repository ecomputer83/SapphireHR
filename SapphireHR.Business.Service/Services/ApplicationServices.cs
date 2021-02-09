using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Data.Service.Repositories;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class ApplicationServices
    {
        private readonly IMapper _mapper;
        private readonly ApplicationRepository _applicationRepository;

        public ApplicationServices(IMapper mapper, ApplicationRepository applicationStore)
        {
            _mapper = mapper;
            _applicationRepository = applicationStore;
        }

        public async Task AddApplicationScore(ApplicationScoreModel model)
        {
            var data = _mapper.Map<ApplicationScore>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSTEM";
            data.UpdatedBy = "SYSTEM";
            await _applicationRepository.AddApplicationScore(data);
        }

        public async Task UpdateApplicationScore(ApplicationScoreModel model, int id)
        {
            var data = await _applicationRepository.ReadApplicationScore(id);
            data.Score = model.Score;
            data.UpdatedAt = DateTime.Now;
            await _applicationRepository.UpdateApplicationScore(data, id);
        }

        public async Task ReadApplicationScore(int id)
        {
            await _applicationRepository.ReadApplicationScore(id);
        }

        public async Task RemoveApplicationScore(int id)
        {
            await _applicationRepository.RemoveApplicationScore(id);
        }

        public async Task AddApplicationFaceToView(ApplicationFaceToViewModel model)
        {
            var data = _mapper.Map<ApplicationFaceToView>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSTEM";
            data.UpdatedBy = "SYSTEM";
            await _applicationRepository.AddApplicationFaceToView(data);
        }

        public async Task UpdateApplicationFaceToView(ApplicationFaceToViewModel model, int id)
        {
            var data = await _applicationRepository.ReadApplicationFaceToView(id);
            data.Rank = model.Rank;
            data.Remark = model.Remark;
            await _applicationRepository.UpdateApplicatioFaceToView(data, id);
        }

        public async Task ReadApplicationFaceToView(int id)
        {
            await _applicationRepository.ReadApplicationFaceToView(id);
        }

        public async Task RemoveApplicationFaceToView(int id)
        {
            await _applicationRepository.RemoveApplicationFaceToView(id);
        }

        public async Task AddApplicationInterview(ApplicationInterviewModel model)
        {
            var data = _mapper.Map<ApplicationInterview>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSSTEM";
            data.UpdatedBy = "SYSTEM";
            await _applicationRepository.AddApplicationInterview(data);
        }

        public async Task UpdateApplicationInterview(ApplicationInterviewModel model, int id)
        {
            var data = await _applicationRepository.ReadApplicationInterview(id);
            data.NoticePeriod = model.NoticePeriod;
            data.SalaryType = model.SalaryType;
            data.StartDate = DateTime.Now;
            data.ExpectedSalary = model.ExpectedSalary;
            data.Remark = model.Remark;
            await _applicationRepository.UpdateApplicationInterview(data, id);
        }

        public async Task ReadApplicationInterview(int id)
        {
            await _applicationRepository.ReadApplicationInterview(id);
        }

        public async Task RemoveApplicationInterview(int id)
        {
            await _applicationRepository.ReadApplicationInterview(id);
        }

        public async Task AddApplicationSkills(ApplicationSkillModel model)
        {
            var data = _mapper.Map<ApplicationSkills>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSSTEM";
            data.UpdatedBy = "SYSTEM";
            await _applicationRepository.AddApplicationSkills(data);
        }

        public async Task UpdateApplicationSkills(ApplicationSkillModel model, int id)
        {
            var data = await _applicationRepository.ReadApplicationSkills(id);
            await _applicationRepository.UpdateApplicationSkills(data, id);
        }

        public async Task ReadApplicationSkills(int id)
        {
            await _applicationRepository.ReadApplicationSkills(id);
        }

        public async Task RemoveApplicationSkills(int id)
        {
            await _applicationRepository.RemoveApplicationSkills(id);
        }

        public async Task AddApplicationNegotiation(ApplicationNegotiationModel model)
        {
            var data = _mapper.Map<ApplicationNegotiation>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSSTEM";
            data.UpdatedBy = "SYSTEM";
            await _applicationRepository.AddApplicationNegotiation(data);
        }

        public async Task UpdateApplicationNegotiation(ApplicationNegotiationModel model, int id)
        {
            var data = await _applicationRepository.ReadApplicationNegotiation(id);
            data.NegotiationCompleted = model.NegotiationCompleted;
            data.RelatedTaskCompleted = model.RelatedTaskCompleted;
            data.FinalDecision = model.FinalDecision;
            await _applicationRepository.UpdateApplicationNegotiation(data, id);
        }
    }
}
