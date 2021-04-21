using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SapphireHR.Business.Abstractions;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Data.Service.Repositories;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class EmailService : IEmailService
    {
        private readonly Mailer _email;
        private readonly IConfiguration _configuration;
        private readonly MailTemplateRepository _mailTemplateRepository;
        private readonly ILogger<EmailService> _logger;
        public EmailService(IOptions<Mailer> email, IConfiguration configuration, ILogger<EmailService> logger, MailTemplateRepository mailTemplateRepository)
        {
            _email = configuration.GetSection("Email").Get<Mailer>();
            _configuration = configuration;
            this._logger = logger;
            this._mailTemplateRepository = mailTemplateRepository;
        }

        public async Task SendWelcomeMessageAsync(string Header, UserModel user)
        {
            try
            {
                var template = await _mailTemplateRepository.GetByCode("WELCOME_MSG");
                var body = template.TemplateBody;
                body = ConvertWelcomeMsgToBodyMessage(body, Header, user);
                if (_email.IsSendgrid)
                {
                    var client = new SendGridClient(_email.Password);
                    var to = new EmailAddress(user.Email);
                    var from = new EmailAddress(_email.From, _email.DisplayName);
                    var msg = MailHelper.CreateSingleEmail(from, to, template.TemplateSubject, body, body);
                    var response = await client.SendEmailAsync(msg);
                    if (!response.IsSuccessStatusCode)
                        throw new Exception(response.Body.ReadAsStringAsync().Result);
                }
                else
                {
                    using (var client = new SmtpClient(_email.Server, _email.Port))
                    {
                        using (var mailMessage = new MailMessage())
                        {
                            if (!_email.DefaultCredentials)
                            {
                                client.UseDefaultCredentials = false;
                                client.Credentials = new NetworkCredential(_email.UserName, _email.Password);
                            }
                            var cc = _email.CC;
                            PrepareMailMessage(_email.DisplayName, template.TemplateSubject, body, _email.From, user.Email, mailMessage, cc);
                            client.EnableSsl = true;
                            await client.SendMailAsync(mailMessage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }
        
        public async Task SendAsync(string EmailDisplayName, string Subject, string Body, string From, string To)
        {
            using (var client = new SmtpClient(_email.Server, _email.Port))
            using (var mailMessage = new MailMessage())
            {
                if (!_email.DefaultCredentials)
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(_email.UserName, _email.Password);
                }

                PrepareMailMessage(EmailDisplayName, Subject, Body, From, To, mailMessage);
                client.EnableSsl = true;
                await client.SendMailAsync(mailMessage);
            }
        }

        public async Task SendEmailConfirmationAsync(string EmailAddress, string Code)
        {
            using (var client = new SmtpClient(_email.Server, _email.Port))
            using (var mailMessage = new MailMessage())
            {
                if (!_email.DefaultCredentials)
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(_email.UserName, _email.Password);
                }

                PrepareMailMessage(_email.DisplayName, "Confirm your email", $"Here is the confirmation code <b>{Code}</b>", _email.From, EmailAddress, mailMessage);
                client.EnableSsl = true;
                await client.SendMailAsync(mailMessage);
            }
        }

        public async Task SendPasswordResetAsync(string EmailAddress, string Code)
        {
            using (var client = new SmtpClient(_email.Server, _email.Port))
            {
                using (var mailMessage = new MailMessage())
                {
                    if (!_email.DefaultCredentials)
                    {
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(_email.UserName, _email.Password);
                    }

                    PrepareMailMessage(_email.DisplayName, "Reset your password", $"Please reset your password with code <b>{Code}</b>", _email.From, EmailAddress, mailMessage);
                    client.EnableSsl = true;
                    await client.SendMailAsync(mailMessage);
                }
            }
        }

        private void PrepareMailMessage(string EmailDisplayName, string Subject, string Body, string From, string To, MailMessage mailMessage, string cc = null)
        {
            mailMessage.From = new MailAddress(From, EmailDisplayName);
            mailMessage.To.Add(To);
            if (!string.IsNullOrEmpty(cc))
                mailMessage.Bcc.Add(cc);

            mailMessage.Body = Body;
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = Subject;
        }

        public async Task SendApplicationLogin(string Org, string Username, string Password, string ApplicantEmail, string Url)
        {
            using (var client = new SmtpClient(_email.Server, _email.Port))
            using (var loginDetails = new MailMessage())
            {
                if (!_email.DefaultCredentials)
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(_email.UserName, _email.Password);
                }

                PrepareMailMessage(_email.DisplayName, $"{Org} Application Login", $"Here is the login Username <b>{Username}</b> and Password <b>{Password}</b> to this <a href=\"{Url}\">link</a> ", _email.From, ApplicantEmail, loginDetails);
                client.EnableSsl = true;
                await client.SendMailAsync(loginDetails);
            }
        }

        private string ConvertWelcomeMsgToBodyMessage(string xc, string header, UserModel model)
        {
            var body = xc;
            body = body.Replace("[header]", header);
            body = body.Replace("[name]", model.FullName);
            body = body.Replace("[email]", model.Email);
            body = body.Replace("[password]", model.Password);

            return body;
        }

        private string ConvertHRMsgToBodyMessage(string xc, string header, string company, UserModel model)
        {
            var body = xc;
            body = body.Replace("[header]", header);
            body = body.Replace("[company]", company);
            body = body.Replace("[name]", model.FullName);
            body = body.Replace("[email]", model.Email);
            body = body.Replace("[password]", model.Password);

            return body;
        }

        private string ConvertEmployeeMsgToBodyMessage(string xc, string header, string company, string destination, UserModel model)
        {
            var body = xc;
            body = body.Replace("[header]", header);
            body = body.Replace("[company]", company);
            body = body.Replace("[destination]", destination);
            body = body.Replace("[name]", model.FullName);
            body = body.Replace("[email]", model.Email);
            body = body.Replace("[password]", model.Password);

            return body;
        }

        public async Task SendHRMessageAsync(string Header, string company, UserModel user)
        {
            try
            {
                var template = await _mailTemplateRepository.GetByCode("HR_REGISTRATION");
                var body = template.TemplateBody;
                body = ConvertHRMsgToBodyMessage(body, Header, company, user);
                if (_email.IsSendgrid)
                {
                    var client = new SendGridClient(_email.Password);
                    var to = new EmailAddress(user.Email);
                    var from = new EmailAddress(_email.From, _email.DisplayName);
                    var msg = MailHelper.CreateSingleEmail(from, to, template.TemplateSubject, body, body);
                    var response = await client.SendEmailAsync(msg);
                    if (!response.IsSuccessStatusCode)
                        throw new Exception(response.Body.ReadAsStringAsync().Result);
                }
                else
                {
                    using (var client = new SmtpClient(_email.Server, _email.Port))
                    {
                        using (var mailMessage = new MailMessage())
                        {
                            if (!_email.DefaultCredentials)
                            {
                                client.UseDefaultCredentials = false;
                                client.Credentials = new NetworkCredential(_email.UserName, _email.Password);
                            }
                            var cc = _email.CC;
                            PrepareMailMessage(_email.DisplayName, template.TemplateSubject, body, _email.From, user.Email, mailMessage, cc);
                            client.EnableSsl = true;
                            await client.SendMailAsync(mailMessage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }

        public async Task SendEmployeeMessageAsync(string Header, string company, string destination, UserModel user)
        {
            try
            {
                var template = await _mailTemplateRepository.GetByCode("EMPLOYEE_REGISTRATION");
                var body = template.TemplateBody;
                body = ConvertEmployeeMsgToBodyMessage(body, Header, company, destination, user);
                if (_email.IsSendgrid)
                {
                    var client = new SendGridClient(_email.Password);
                    var to = new EmailAddress(user.Email);
                    var from = new EmailAddress(_email.From, _email.DisplayName);
                    var msg = MailHelper.CreateSingleEmail(from, to, template.TemplateSubject, body, body);
                    var response = await client.SendEmailAsync(msg);
                    if (!response.IsSuccessStatusCode)
                        throw new Exception(response.Body.ReadAsStringAsync().Result);
                }
                else
                {
                    using (var client = new SmtpClient(_email.Server, _email.Port))
                    {
                        using (var mailMessage = new MailMessage())
                        {
                            if (!_email.DefaultCredentials)
                            {
                                client.UseDefaultCredentials = false;
                                client.Credentials = new NetworkCredential(_email.UserName, _email.Password);
                            }
                            var cc = _email.CC;
                            PrepareMailMessage(_email.DisplayName, template.TemplateSubject, body, _email.From, user.Email, mailMessage, cc);
                            client.EnableSsl = true;
                            await client.SendMailAsync(mailMessage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }

        //private string ConvertOrderToBodyMessage(string xc, OrderViewModel model)
        //{
        //    var body = xc;
        //    body = body.Replace("{PRODUCT}", model.ProductName);
        //    body = body.Replace("{DEPOT}", model.DepotName);
        //    body = body.Replace("{OrderNo}", model.OrderNo);
        //    body = body.Replace("{Quantity}", model.Quantity.ToString("N", CultureInfo.CurrentCulture));
        //    body = body.Replace("{TotalAmount}", "₦ " + model.TotalAmount.ToString("N", CultureInfo.CurrentCulture));
        //    body = body.Replace("{Price}", "₦ " + (model.TotalAmount / model.Quantity).ToString("N", CultureInfo.CurrentCulture));

        //    return body;
        //}
    }
}
