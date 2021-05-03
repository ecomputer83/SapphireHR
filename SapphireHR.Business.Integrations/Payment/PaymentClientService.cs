using Microsoft.Extensions.Configuration;
using SapphireHR.Business.Abstractions;
using SapphireHR.Business.Integrations.RestApi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Integrations
{
    public class PaymentClientService
    {
        private IConfiguration configuration;
        string baseUrl;
        public PaymentClientService(IConfiguration _configuration)
        {
            configuration = _configuration;
            var testmode = Convert.ToBoolean(int.Parse(configuration.GetSection("Payment")["IsTest"]));
            baseUrl = testmode ? configuration.GetSection("Payment")["DemoUrl"] : configuration.GetSection("Payment")["LiveUrl"];
        }
        public Task<RemitaLoginResponse> Authenticate(RemitaLogin request)
        {
            var resource = $"/uaasvc/uaa/token";
            var resp = RestService.RestClientCall<RemitaLoginResponse>(this.baseUrl, resource, RestSharp.Method.POST, request, null);
            return Task.FromResult(resp);
        }

        public Task<RemitaSalaryResponse> PaySalary(RemitaSalaryRequest request, string Auth)
        {
            var resource = $"/rpgsvc/v3/rpg/bulk/payment";
            var resp = RestService.RestClientCall<RemitaSalaryResponse>(this.baseUrl, resource, RestSharp.Method.POST, request, Auth);
            return Task.FromResult(resp);
        }

        public Task<RemitaRegulatoryResponse> PayPension(RemitaPensionRequest request, string Auth)
        {
            var resource = $"/schedulesvc/schedule-delivery/pension/process";
            var resp = RestService.RestClientCall<RemitaRegulatoryResponse>(this.baseUrl, resource, RestSharp.Method.POST, request, Auth);
            return Task.FromResult(resp);
        }

        public Task<RemitaRegulatoryResponse> PayTax(RemitaTaxRequest request, string Auth)
        {
            var resource = $"/schedulesvc/schedule-delivery/tax/process/PAYE";
            var resp = RestService.RestClientCall<RemitaRegulatoryResponse>(this.baseUrl, resource, RestSharp.Method.POST, request, Auth);
            return Task.FromResult(resp);
        }

        public Task<TaxCodeResponse> GetTaxCodes(string Auth)
        {
            var resource = $"/schedulesvc/schedule-delivery/TAX/codes";
            var resp = RestService.RestClientCall<TaxCodeResponse>(this.baseUrl, resource, RestSharp.Method.GET, null, Auth);
            return Task.FromResult(resp);
        }

        public Task<PensionCodeResponse> GetPensionCodes(string Auth)
        {
            var resource = $"/schedulesvc/schedule-delivery/PENSION/codes";
            var resp = RestService.RestClientCall<PensionCodeResponse>(this.baseUrl, resource, RestSharp.Method.GET, null, Auth);
            return Task.FromResult(resp);
        }
    }
}
