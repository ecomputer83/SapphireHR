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

        public MiscellaneousController(ILogger<MiscellaneousController> logger, IMiscellaneousService miscellaneousService)
        {
            _logger = logger;
            _miscellaneousService = miscellaneousService;
        }

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [Route("createApplicantById")]
        public async Task<IActionResult> PostApplicantById([FromBody] ApplicantModel model)
        {
            try
            {
                await _miscellaneousService.AddApplicant(model);
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
        [Route("createDepartmentById")]
        public async Task<IActionResult> PostDepartmentById([FromBody] DepartmentModel model)
        {
            try
            {
                await _miscellaneousService.AddDepartment(model);
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
        [Route("createDesignationById")]
        public async Task<IActionResult> PostDesignationId([FromBody] DesignationModel model)
        {
            try
            {
                await _miscellaneousService.AddDesignation(model);
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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
        
        [Authorize(Roles = "Administrator")]
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
