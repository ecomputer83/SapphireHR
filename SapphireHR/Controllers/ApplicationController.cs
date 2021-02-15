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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApplicationController : BaseApiController
    {
        IApplicationService _applicationService;
        private readonly ILogger<ApplicationController> _logger;

        public ApplicationController(IApplicationService applicationService, ILogger<ApplicationController> logger)
        {
            _applicationService = applicationService;
            _logger = logger;
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetApplicationScore(int id)
        {
            try
            {
                var resource = await _applicationService.ReadApplicationScore(id);
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetApplicationFaceToView(int id)
        {
            try
            {
                var resource = await _applicationService.ReadApplicationFaceToView(id);
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetApplicationInterview(int id)
        {
            try
            {
                var resource = await _applicationService.ReadApplicationInterview(id);
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetApplicationSkill(int id)
        {
            try
            {
                var resource = await _applicationService.ReadApplicationSkills(id);
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetApplicationNegotiation(int id)
        {
            try
            {
                var resource = await _applicationService.ReadApplicationNegotiation(id);
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> PostApplicationScore([FromBody] ApplicationScoreModel payload)
        {
            try
            {
                await _applicationService.AddApplicationScore(payload);
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
        public async Task<IActionResult> PostApplicationFaceToView([FromBody] ApplicationFaceToViewModel payload)
        {
            try
            {
                await _applicationService.AddApplicationFaceToView(payload);
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
        public async Task<IActionResult> PostApplicationInterview([FromBody] ApplicationInterviewModel payload)
        {
            try
            {
                await _applicationService.AddApplicationInterview(payload);
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
        public async Task<IActionResult> PostApplicationSkills([FromBody] ApplicationSkillModel payload)
        {
            try
            {
                await _applicationService.AddApplicationSkills(payload);
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
        public async Task<IActionResult> PostApplicationNegotiation([FromBody] ApplicationNegotiationModel payload)
        {
            try
            {
                await _applicationService.AddApplicationNegotiation(payload);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationScore(int id, [FromBody] ApplicationScoreModel payload)
        {
            try
            {
                await _applicationService.UpdateApplicationScore(payload, id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }


        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationFaceToView(int id, [FromBody] ApplicationFaceToViewModel payload)
        {
            try
            {
                await _applicationService.UpdateApplicationFaceToView(payload, id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationInterview(int id, [FromBody] ApplicationInterviewModel payload)
        {
            try
            {
                await _applicationService.UpdateApplicationInterview(payload, id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationSkills(int id, [FromBody] ApplicationSkillModel payload)
        {
            try
            {
                await _applicationService.UpdateAddApplicationSkills(payload, id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationNegotiation(int id, [FromBody] ApplicationNegotiationModel payload)
        {
            try
            {
                await _applicationService.UpdateApplicationNegotiation(payload, id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationScore(int id)
        {
            try
            {
                await _applicationService.RemoveApplicationScore( id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationNegotiation(int id)
        {
            try
            {
                await _applicationService.RemoveApplicationNegotiation(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationSkills(int id)
        {
            try
            {
                await _applicationService.RemoveApplicationSkills(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationInterview(int id)
        {
            try
            {
                await _applicationService.RemoveApplicationInterview(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationFaceToView(int id)
        {
            try
            {
                await _applicationService.RemoveApplicationFaceToView(id);
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