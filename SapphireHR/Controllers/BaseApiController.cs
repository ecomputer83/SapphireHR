using Microsoft.AspNetCore.Mvc;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SapphireHR.Web.Controllers
{
    public class BaseApiController : ControllerBase
    {
        IOrganizationService _organizationService;
        public BaseApiController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }
        [NonAction]
        protected IActionResult CreateApiException(Exception ex)
        {
            return Problem(ex.StackTrace, ex.Source, 500, ex.Message);
        }

        [NonAction]
        public async Task<OrganizationModel> GetOrganizationByHeader()
        {
            var host = Request.Headers["Holder"];
            return await _organizationService.GetOrganizationByHostHeader(host);
        }

        public string GetClientUrl()
        {
            var host = Request.Headers["Referer"];
            return host;
        }
    }
}
