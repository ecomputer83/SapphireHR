using Microsoft.Extensions.DependencyInjection;
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
            }
        }

    }
}
