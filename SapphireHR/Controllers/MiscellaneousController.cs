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
    public class MiscellaneousController : BaseApiController
    {
        private readonly ILogger _logger;
        IMiscellaneousService _miscellaneousService;
        IOrganizationService _organizationService;

        public MiscellaneousController(ILogger<MiscellaneousController> logger, IMiscellaneousService miscellaneousService, IOrganizationService organizationService) : base(organizationService)
        {
            _logger = logger;
            _miscellaneousService = miscellaneousService;
            _organizationService = organizationService;
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getApplicantById")]
        public async Task<IActionResult> GetApplicantById(int id)
        {
            try
            {
                var res = await _miscellaneousService.GetApplicant(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getAllApplicant")]
        public async Task<IActionResult> GetApplicants()
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _miscellaneousService.GetApplicants(org.Id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }


        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getDepartmentById")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            try
            {
                var res = await _miscellaneousService.GetDepartment(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getDepartments")]
        public async Task<IActionResult> GetDepartments()
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _miscellaneousService.GetDepartments(org.Id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getDesignations")]
        public async Task<IActionResult> GetDesignations()
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _miscellaneousService.GetDesignations(org.Id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getDesignationById")]
        public async Task<IActionResult> GetDesignationById(int id)
        {
            try
            {
                var res = await _miscellaneousService.GetDesignation(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        [Route("createApplicant")]
        public async Task<IActionResult> PostApplicant([FromBody] ApplicantModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                model.OrganizationId = org.Id;
                await _miscellaneousService.AddApplicant(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        [Route("createDepartment")]
        public async Task<IActionResult> PostDepartment([FromBody] DepartmentModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                model.OrganizationId = org.Id;
                await _miscellaneousService.AddDepartment(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        [Route("createDesignation")]
        public async Task<IActionResult> PostDesignation([FromBody] DesignationModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                model.OrganizationId = org.Id;
                await _miscellaneousService.AddDesignation(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateApplicant")]
        public async Task<IActionResult> UpdateApplicant([FromBody] ApplicantModel model)
        {
            try
            {
                await _miscellaneousService.UpdateApplicant(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateDepartment")]
        public async Task<IActionResult> UpdateDepartment([FromBody] DepartmentModel model)
        {
            try
            {
                await _miscellaneousService.UpdateDepartment(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateDesignation")]
        public async Task<IActionResult> UpdateDesignation([FromBody] DesignationModel model)
        {
            try
            {
                await _miscellaneousService.UpdateDesignation(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
        [Route("deleteApplicant")]
        public async Task<IActionResult> DeleteApplicant(int id)
        {
            try
            {
                await _miscellaneousService.RemoveApplicant(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
        [Route("deleteDepartment")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            try
            {
                await _miscellaneousService.RemoveDepartment(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        
        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
        [Route("deleteDesignation")]
        public async Task<IActionResult> DeleteDesignation(int id)
        {
            try
            {
                await _miscellaneousService.RemoveDesignation(id);
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
