using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IEmailService
    {
        Task SendWelcomeMessageAsync(object oc, string Type, string To);
        Task SendAsync(string EmailDisplayName, string Subject, string Body, string From, string To);

        Task SendEmailConfirmationAsync(string Email, string Code);

        Task SendPasswordResetAsync(string Email, string Code);
        Task SendApplicationLogin(string Org, string Username, string Password, string ApplicantEmail, string Url);
    }
}
