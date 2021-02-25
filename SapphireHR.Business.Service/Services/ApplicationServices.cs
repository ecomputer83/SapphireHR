using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Data.Service.Repositories;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class ApplicationServices : IApplicationService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationRepository _applicationRepository;
        private readonly OrganizationRepository _organizationRepository;
        private readonly ApplicantRepository _applicantRepository;
        private readonly IEmailService _emailService;

        public ApplicationServices(IMapper mapper, ApplicationRepository applicationStore, ApplicantRepository applicantRepository,
            OrganizationRepository organizationRepository, IEmailService emailService)
        {
            _mapper = mapper;
            _applicationRepository = applicationStore;
            _organizationRepository = organizationRepository;
            _applicantRepository = applicantRepository;
            _emailService = emailService;
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

        public async Task<ApplicationScoreModel> ReadApplicationScore(int id)
        {
            var rsc = await _applicationRepository.ReadApplicationScore(id);
            var appScore = _mapper.Map<ApplicationScoreModel>(rsc);
            return appScore;
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

        public async Task<ApplicationFaceToViewModel> ReadApplicationFaceToView(int id)
        {
            var result = await _applicationRepository.ReadApplicationFaceToView(id);
            var appFtv = _mapper.Map<ApplicationFaceToViewModel>(result);
            return appFtv;
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

        public async Task<ApplicationInterviewModel> ReadApplicationInterview(int id)
        {
            var result = await _applicationRepository.ReadApplicationInterview(id);
            var appInterview = _mapper.Map<ApplicationInterviewModel>(result);
            return appInterview;
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

        public async Task<ApplicationSkillModel> ReadApplicationSkills(int id)
        {
            var result = await _applicationRepository.ReadApplicationSkills(id);
            var appSkill = _mapper.Map<ApplicationSkillModel>(result);
            return appSkill;
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

        public async Task<ApplicationNegotiationModel> ReadApplicationNegotiation(int id)
        {
            var result = await _applicationRepository.ReadApplicationNegotiation(id);
            var appNeg = _mapper.Map<ApplicationNegotiationModel>(result);
            return appNeg;
        }

        public async Task RemoveApplicationNegotiation(int id)
        {
            await _applicationRepository.RemoveApplicationNegotiation(id);
        }

        public async Task UpdateApplicationFaceToViewModel(ApplicationFaceToViewModel model, int id)
        {
            var data = await _applicationRepository.ReadApplicationFaceToView(id);
            data.Rank = model.Rank;
            data.Remark = model.Remark;
            await _applicationRepository.UpdateApplicatioFaceToView(data, id);
        }


        public async Task UpdateAddApplicationSkills(ApplicationSkillModel model, int id)
        {
            var data = await _applicationRepository.ReadApplicationSkills(id);
            await _applicationRepository.UpdateApplicationSkills(data, id);
        }

        public async Task AddApplicationLogin(ApplicationLoginModel model)
        {
            var data = _mapper.Map<ApplicationLogin>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSSTEM";
            data.UpdatedBy = "SYSTEM";
            await _applicationRepository.AddApplicationLogin(data);
        }

        public async Task<ApplicationModel> GetApplicationLogin(string username, string password)
        {
            var result = await _applicationRepository.GetApplicationLogin(username, password);
            var data = _mapper.Map<ApplicationModel>(result);
            return data;
        }

        public async Task<int> AddApplication(int OrgId, ApplicationModel model, string Url)
        {
            var data = _mapper.Map<Application>(model);
            data.CreatedAt = DateTime.Now;
            data.UpdatedAt = DateTime.Now;
            data.CreatedBy = "SYSSTEM";
            data.UpdatedBy = "SYSTEM";
            data = await _applicationRepository.Add(data);

            // Get OrganizationDetails
            var org = await _organizationRepository.Get(OrgId);

            // Get Applicant Details
            var applicant = await _applicantRepository.Get(model.ApplicantId);
            //Generate Application Login
            var generator = new RandomGenerator();
            var loginmodel = new ApplicationLogin
            {
                ApplicationId = data.Id,
                UserName = generator.RandomString(15),
                Password = generator.RandomPassword()
            };

            await _applicationRepository.AddApplicationLogin(loginmodel);

            //Send Application Login to Applicant
            await _emailService.SendApplicationLogin(org.Name, loginmodel.UserName, loginmodel.Password, applicant.Email, Url);

            return data.Id;
        }
    

        public async Task<ApplicationModel> GetApplicationById(int id)
        {
            var result = await _applicationRepository.GetApplication(id);
            var appFtv = _mapper.Map<ApplicationModel>(result);
            return appFtv;
        }

        public async Task UpdateApplication(ApplicationModel model, int id)
        {
            var data = await _applicationRepository.Get(id);
            data.CoverLetter = model.CoverLetter;
            data.Document = model.Document;
            data.ExpectedSalary = model.ExpectedSalary;
            data.NoticePeriod = model.NoticePeriod;
            data.StartDate = model.StartDate;
            await _applicationRepository.UpdateApplication(data, id);
        }

        public async Task<List<ApplicationModel>> GetAllApplication(int companyId)
        {
            var result = await _applicationRepository.GetApplicationByCompany(companyId);
            var appInterview = _mapper.Map<List<ApplicationModel>>(result);
            return appInterview;
        }

        public async Task RemoveApplication(int id)
        {
            await _applicationRepository.RemoveApplication(id);
        }
    }
}
