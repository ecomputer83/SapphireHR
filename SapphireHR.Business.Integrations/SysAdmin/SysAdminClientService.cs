using Microsoft.Extensions.Configuration;
using SapphireHR.Business.Abstractions;
using SapphireHR.Business.Integrations.RestApi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Integrations
{
    public class SysAdminClientService
    {
        private IConfiguration configuration;
        string baseUrl;
        public SysAdminClientService(IConfiguration _configuration)
        {
            configuration = _configuration;
            baseUrl = configuration.GetSection("SysAdmin")["Url"];
        }
        public Task PostHostHeader(SysAdminRequest request)
        {
            var resource = $"/api/Sys";
            RestService.RestClientCall(this.baseUrl, resource, RestSharp.Method.POST, request, true);
            return Task.CompletedTask;
        }
    }
}
