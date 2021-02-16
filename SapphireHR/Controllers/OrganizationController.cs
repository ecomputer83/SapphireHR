using Microsoft.AspNetCore.Authorization;
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
        public OrganizationController(IOrganizationService organizationService, ILogger<OrganizationController> logger)
        {
            this._organizationService = organizationService;
            this._logger = logger;
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [Route("addleavetype")]
        public async Task<IActionResult> AddLeaveType([FromBody] LeaveTypeModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
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
        public async Task<IActionResult> AddRank([FromBody] RankModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var rank = await _organizationService.GetRank(model.RankName);
                if (rank == null)
                {
                    model.OrganizationId = org.Id;
                    var id = await _organizationService.AddRank(model);
                    model.RankPermissionModel.RankId = id;
                    await _organizationService.AddRankPermission(model.RankPermissionModel);

                    return Ok(id);
                }
                else
                {
                    return Ok(rank.Id);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [Route("updaterank/{id}")]
        public async Task<IActionResult> UpdateRank([FromBody] RankModel model, int Id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                model.OrganizationId = org.Id;
                await _organizationService.UpdateRank(model, Id);
                var pId = model.RankPermissionModel.Id;
                await _organizationService.UpdateRankPermission(model.RankPermissionModel, pId);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("ranks")]
        public async Task<IActionResult> GetRanks()
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _organizationService.GetRanks(org.Id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("leavetypes")]
        public async Task<IActionResult> GetLeaveTypes()
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if(org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _organizationService.GetLeaveTypes(org.Id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        [HttpPost]
        //[AllowAnonymous]
        public async Task<IActionResult> Post([FromBody] OrganizationModel model)
        {
            try
            {
                var id = await _organizationService.AddOrganization(model);
                return Ok(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        [HttpPost]
        [Route("PostHeader")]
        //[AllowAnonymous]
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
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
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
            var host = Request.Headers["Holder"];
            return await _organizationService.GetOrganizationByHostHeader(host);
        }
    }
}
