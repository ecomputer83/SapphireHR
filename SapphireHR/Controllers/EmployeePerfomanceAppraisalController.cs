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
    public class EmployeePerfomanceAppraisalController : BaseApiController
    {
        private readonly IOrganizationService _organizationService;
        private readonly ILogger<EmployeePerfomanceAppraisalController> _logger;
        private readonly IEmployeePerfomanceAppraisal _employeePerfomanceAppraisal;

        public EmployeePerfomanceAppraisalController(IOrganizationService organizationService, ILogger<EmployeePerfomanceAppraisalController> logger, IEmployeePerfomanceAppraisal employeePerfomanceAppraisal) : base(organizationService)
        {
            _organizationService = organizationService;
            _logger = logger;
            _employeePerfomanceAppraisal = employeePerfomanceAppraisal;
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeePerfomanceAppraisal(int id)
        {
            try
            {
                var rsc = await _employeePerfomanceAppraisal.GetEmployeePerfomanceAppraisal(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllEmployeePerfomanceAppraisal(int id)
        {
            try
            {
                var rsc = await _employeePerfomanceAppraisal.GetAllEmployeePerfomanceAppraisal(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeePerfomanceAppraisal([FromBody] EmployeePerfomanceAppraisalModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _employeePerfomanceAppraisal.AddEmployeePerfomanceAppraisal(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployeePerfomanceAppraisal([FromBody] EmployeePerfomanceAppraisalModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _employeePerfomanceAppraisal.UpdateEmployeePerfomanceAppraisal(model, id);

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
