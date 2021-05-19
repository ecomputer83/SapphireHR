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
        public CompanyController(IOrganizationService organizationService, ICompanyService companyService, ILogger<CompanyController> logger) : base(organizationService)
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
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }

                model.OrganizationId = org.Id;

                var id = await _companyService.AddCompany(model);
                return Ok(id);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        [Route("PostAccount")]
        public async Task<IActionResult> PostAccount(CompanyAccountModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }


                await _companyService.AddCompanyAccount(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        [Route("PostLeavePolicy")]
        public async Task<IActionResult> PostLeavePolicy(LeavePolicyModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }


                await _companyService.AddLeavePolicy(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        [Route("InitiateLeaveSetting")]
        public async Task<IActionResult> InitiateLeaveSetting(int id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }

                var types = await _organizationService.GetLeaveTypes(org.Id);
                foreach (var type in types)
                {
                    var model = new LeaveSettingModel
                    {
                        TypeId = type.Id,
                        CompanyId = id
                    };
                    await _companyService.AddLeaveSetting(model);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var company = await _companyService.GetCompany(org.Id);
                return Ok(company);
            }
            catch (Exception ex)
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
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var companies = await _companyService.GetCompanies(org.Id);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetAccount")]
        public async Task<IActionResult> GetAccount(int id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var companies = await _companyService.GetCompanyAccount(id);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetLeaveSettings")]
        public async Task<IActionResult> GetLeaveSettings(int id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var companies = await _companyService.GetLeaveSetting(id);
                return Ok(companies);
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
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
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

        [Authorize]
        [HttpPut]
        [Route("PutAccount")]
        public async Task<IActionResult> PutAccount(CompanyAccountModel model, int Id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }

                await _companyService.UpdateCompanyAccount(model, Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPut]
        [Route("PutLeaveSetting")]
        public async Task<IActionResult> PutLeaveSetting(LeaveSettingModel model, int Id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }

                await _companyService.UpdateLeaveSetting(model, Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPut]
        [Route("PutLeavePolicy")]
        public async Task<IActionResult> PutLeavePolicy(LeavePolicyModel model, int Id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }

                await _companyService.UpdateLeavePolicy(model, Id);
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
        [Route("Inactive")]
        public async Task<IActionResult> Inactive(int Id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }

                await _companyService.InactiveCompany(Id);
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
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                await _companyService.RemoveCompany(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
    }
}
