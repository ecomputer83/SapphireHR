using Microsoft.Extensions.DependencyInjection;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Business.DocumentManager.Documents;
using SapphireHR.Business.Service.Services;
using SapphireHR.Data.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Service
{
    public static class ServiceExtensions
    {
        public static void SetupRegistration(this IServiceCollection services, bool useMockForDatabase, bool useMockForIntegrations)
        {
            //data layer services
            if (useMockForDatabase)
            {
                //services.AddSingleton<ICustomerDataService, MockCustomerDataService>();
            }
            else
            {
                services.AddScoped<OrganizationRepository>();
                services.AddScoped<CompanyRepository>();
                services.AddScoped<JobRepository>();
                services.AddScoped<EmployeeRepository>();
                services.AddScoped<ApplicantRepository>();
                services.AddScoped<ApplicationRepository>();
                services.AddScoped<DepartmentRepository>();
                services.AddScoped<DesignationRepository>();
            }
            services.AddScoped<FileManager>();
            services.AddTransient<IApplicationService, ApplicationServices>();
            services.AddTransient<ICompanyService, CompanyServices>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IEmployeeService, EmployeeServices>();
            services.AddTransient<IJobService, JobServices>();
            services.AddTransient<IMiscellaneousService, MiscellaneousServices>();
            services.AddTransient<IOrganizationService, OrganizationServices>();
            services.AddTransient<IUserService, UserService>();
        }

    }
}
