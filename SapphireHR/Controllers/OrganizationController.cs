using Microsoft.AspNetCore.Mvc;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SapphireHR.Web.Controllers
{
    public class OrganizationController : BaseApiController
    {
        IOrganizationService _organizationService;
        public OrganizationController(IOrganizationService organizationService)
        {
            this._organizationService = organizationService;
        }
        public IActionResult Index()
        {
            return Ok();
        }

        public async Task<IActionResult> AddLeaveType(LeaveTypeModel model)
        {
            await _organizationService.AddLeaveType(model);
            return Ok();
        }

        public async Task<IActionResult> AddRank(RankModel model)
        {
            await _organizationService.AddRank(model);
            return Ok();
        }

        public async Task<IActionResult> AddOrganization(OrganizationModel model)
        {
            await _organizationService.AddOrganization(model);
            return Ok();
        }

        public async Task<IActionResult> AddOrganizationHeader(OrganizationHeaderModel model)
        {
            await _organizationService.AddOrganizationHeader(model);
            return Ok();
        }

        public async Task<IActionResult> DeleteOrganization(int Id)
        {
            await _organizationService.DeleteOrganization(Id);
            return Ok();
        }

        public async Task<IActionResult> DeleteLeaveType(int Id)
        {
            await _organizationService.RemoveLeaveType(Id);
            return Ok();
        }

    }
}
