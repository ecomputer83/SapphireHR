using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SapphireHR.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : BaseApiController
    {
        ICompanyService _companyService;
        IOrganizationService _organizationService;
        private readonly ILogger<CompanyController> _logger;
        public CompanyController(IOrganizationService organizationService, ICompanyService companyService, ILogger<CompanyController> logger)
        {
            this._companyService = companyService;
            this._organizationService = organizationService;
            this._logger = logger;
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Post(CompanyModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                model.OrganizationId = org.Id;

                await _companyService.AddCompany(model);
                return Ok();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var org = await GetOrganizationByHeader();
                await _companyService.GetCompanies(org.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut]
        public async Task<IActionResult> Put(CompanyModel model, int Id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                model.OrganizationId = org.Id;

                await _companyService.UpdateCompany(model, Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        [Authorize(Roles = "Administrator")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                await _companyService.RemoveCompany(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        private async Task<OrganizationModel> GetOrganizationByHeader()
        {
            var host = Request.Headers["host"];
            return await _organizationService.GetOrganizationByHostHeader(host);
        }
    }
}
