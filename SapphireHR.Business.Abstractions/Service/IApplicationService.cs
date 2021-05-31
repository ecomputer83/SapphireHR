﻿using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IApplicationService
    {
        Task AddApplicationLogin(ApplicationLoginModel model);
        Task<ApplicationModel> GetApplicationLogin(string username, string password);
        Task<int> GetAllApplicationCount(int companyId);

        Task<int> AddApplication(ApplicationModel model);
        Task<ApplicationModel> GetApplicationById(int id);
        Task<ApplicationModel> GetApplicationByApplicant(int vacancy, int applicant);
        Task UpdateApplication(ApplicationModel model, int id);
        Task<List<ApplicationModel>> GetAllApplication(int companyId);
        Task<List<ApplicationModel>> GetAcceptedApplication(int companyId);
        Task RemoveApplication(int id);


        Task AddApplicationScore(ApplicationScoreModel model);
        Task UpdateApplicationScore(ApplicationScoreModel model, int id);
        Task<ApplicationScoreModel> ReadApplicationScore(int id);
        Task RemoveApplicationScore(int id);


        Task AddApplicationFaceToView(ApplicationFaceToViewModel model);
        Task UpdateApplicationFaceToView(ApplicationFaceToViewModel model, int id);
        Task<ApplicationFaceToViewModel> ReadApplicationFaceToView(int id);
        Task RemoveApplicationFaceToView(int id);


        Task AddApplicationInterview(ApplicationInterviewModel model);
        Task UpdateApplicationInterview(ApplicationInterviewModel model, int id);
        Task<ApplicationInterviewModel> ReadApplicationInterview(int id);
        Task RemoveApplicationInterview(int id);


        Task AddApplicationSkills(ApplicationSkillModel model);
        Task UpdateAddApplicationSkills(ApplicationSkillModel model, int id);
        Task<ApplicationSkillModel> ReadApplicationSkills(int id);
        Task RemoveApplicationSkills(int id);


        Task AddApplicationNegotiation(ApplicationNegotiationModel model);
        Task UpdateApplicationNegotiation(ApplicationNegotiationModel model, int id);
        Task<ApplicationNegotiationModel> ReadApplicationNegotiation(int id);
        Task RemoveApplicationNegotiation(int id);


    }
}
