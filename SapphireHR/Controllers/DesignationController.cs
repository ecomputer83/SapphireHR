using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SapphireHR.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DesignationController : BaseApiController
    {
        IOrganizationService _organizationService;
        private readonly ILogger<DesignationController> _logger;
        IDesignationService _designationService;

        public DesignationController(ILogger<DesignationController> logger,IOrganizationService organizationService, IDesignationService designationService) : base(organizationService)
        {
            _organizationService = organizationService;
            _designationService = designationService;
            _logger = logger;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetDesignationByEmployee(int id)
        {
            try
            {
                var rsc = await _designationService.GetDesignationByEmployee(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetDesignationPerformances()
        {
            try
            {
                var rsc = await _designationService.GetDesignationPerformances();
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
        public async Task<IActionResult> GetDesignationPerformance(int id)
        {
            try
            {
                var rsc = await _designationService.GetDesignationPerformance(id);
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
        public async Task<IActionResult> GetDesignationPerformanceByDesignationId(int id)
        {
            try
            {
                var rsc = await _designationService.GetDesignationPerformanceByDesignationId(id);
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
        public async Task<IActionResult> PostDesignationPerformance([FromBody] DesignationPerformanceModel payload)
        {
            try

            {
                await _designationService.AddDesignationPerformance(payload);
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
        public async Task<IActionResult> PutDesignationPerformance([FromBody] DesignationPerformanceModel payload)
        {
            try

            {
                await _designationService.UpdateDesignationPerformance(payload);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDesignationPerformance(int id)
        {
            try
            {
                await _designationService.RemoveDesignationPerformance(id);
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
