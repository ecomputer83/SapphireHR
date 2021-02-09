using Microsoft.Extensions.DependencyInjection;
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
            }
        }

    }
}
