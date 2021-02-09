﻿using Microsoft.AspNetCore.Authorization;
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
    public class OrganizationController : BaseApiController
    {
        IOrganizationService _organizationService;
        private readonly ILogger<OrganizationController> _logger;
        public OrganizationController(IOrganizationService organizationService)
        {
            this._organizationService = organizationService;
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [Route("addleavetype")]
        public async Task<IActionResult> AddLeaveType([FromBody] LeaveTypeModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                model.OrganizationId = org.Id;
                await _organizationService.AddLeaveType(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [Route("addrank")]
        public async Task<IActionResult> AddRank(RankModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                model.OrganizationId = org.Id;
                await _organizationService.AddRank(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        [HttpPost]
        
        public async Task<IActionResult> Post([FromBody] OrganizationModel model)
        {
            try
            {
                await _organizationService.AddOrganization(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        [HttpPost]
        [Route("PostHeader")]
        public async Task<IActionResult> AddOrganizationHeader([FromBody] OrganizationHeaderModel model)
        {
            try
            {
                await _organizationService.AddOrganizationHeader(model);
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
                await _organizationService.DeleteOrganization(Id);
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
        [Route("DeleteLeaveType")]
        public async Task<IActionResult> DeleteLeaveType(int Id)
        {
            try
            {
                await _organizationService.RemoveLeaveType(Id);
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
