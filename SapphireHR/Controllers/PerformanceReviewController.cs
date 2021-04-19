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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PerformanceReviewController : BaseApiController
    {
        IOrganizationService _organizationService;
        IPerformanceReviewService _performanceReviewService;
        private readonly ILogger<PerformanceReviewController> _logger;
        public PerformanceReviewController(IOrganizationService organizationService, IPerformanceReviewService performanceReviewService, ILogger<PerformanceReviewController> logger) : base(organizationService)
        {
            _organizationService = organizationService;
            _performanceReviewService = performanceReviewService;
            _logger = logger;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddProffesionalExcellenceSettings([FromBody] ProffesionalExcellenceSettingsModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.AddProffesionalExcellenceSettings(model);

                return Ok();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddPersonalExcellenceSettings([FromBody] PersonalExcellenceSettingsModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.AddPersonalExcellenceSettings(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonalExcellenceSettings(int id)
        {
            try
            {

                var settings = await _performanceReviewService.GetPersonalExcellenceSettingsModels(id);

                return Ok(settings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProffesionalExcellenceSettings(int id)
        {
            try
            {

                var settings = await _performanceReviewService.GetProffesionalExcellenceSettingsModels(id);

                return Ok(settings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProffesionalExcellenceSettings([FromBody] ProffesionalExcellenceSettingsModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateProffesionalExcellenceSettings(model, id);

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
        public async Task<IActionResult> UpdatePersonalExcellenceSettings([FromBody] PersonalExcellenceSettingsModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdatePersonalExcellenceSettings(model, id);

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
        public async Task<IActionResult> RemoveProffesionalExcellenceSettings(int id)
        {
            try
            {
                await _performanceReviewService.RemoveProffesionalExcellenceSettings(id);
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
        public async Task<IActionResult> RemovePersonalExcellenceSettings(int id)
        {
            try
            {
                await _performanceReviewService.RemovePersonalExcellenceSettings(id);
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
