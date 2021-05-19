using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IEmailService
    {
        Task SendWelcomeMessageAsync(string Header, string orgName, UserModel user);
        Task SendHRMessageAsync(string Header, string company, UserModel user);
        Task SendEmployeeMessageAsync(string Header, string company, string destination, UserModel user);
        Task SendAsync(string EmailDisplayName, string Subject, string Body, string From, string To);

        Task SendEmailConfirmationAsync(string Email, string Code);

        Task SendPasswordResetAsync(string Email, string Code);
        Task SendApplicationLogin(string Company, string WelcomeMessage, string Name, string ApplicantEmail);
    }
}
