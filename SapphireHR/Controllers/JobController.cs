using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SapphireHR.Business.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SapphireHR.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : BaseApiController
    {
        IJobService _jobService;
        private readonly ILogger<JobController> _logger;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("getJobProfiles")]
        public async Task<IActionResult> GetJobProfiles()
        {
            try
            {
                var resource = await _jobService.GetJobProfiles();
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("getJobProfessions")]
        public async Task<IActionResult> GetJobProfessions()
        {
            try
            {
                var resource = await _jobService.GetJobProfessions();
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("getJobSkillLevels")]
        public async Task<IActionResult> GetJobSkillLevels()
        {
            try
            {
                var resource = await _jobService.GetJobSkillLevels();
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("getSkillGrades")]
        public async Task<IActionResult> GetSkillGrades()
        {
            try
            {
                var resource = await _jobService.GetSkillGrades();
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("getVacancies")]
        public async Task<IActionResult> GetVacancies()
        {
            try
            {
                var resource = await _jobService.GetVacancies();
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
        [Route("getVacancyById")]
        public async Task<IActionResult> GetVacancyById(int id)
        {
            try
            {
                var rsc = await _jobService.GetVacancyById(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }            
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        [Route("getSkillGradeById")]
        public async Task<IActionResult> GetSkillGradeById(int id)
        {
            try
            {
                var rsc = await _jobService.GetSkillGradeById(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        [Route("getJobSkillLevelById")]
        public async Task<IActionResult> GetJobSkillLevelById(int id)
        {
            try
            {
                var rsc = await _jobService.GetJobSkillLevelById(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        [Route("getVacancyById")]
        public async Task<IActionResult> GetJobProfessionById(int id)
        {
            try
            {
                var rsc = await _jobService.GetJobProfessionById(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        [Route("getJobProfileById")]
        public async Task<IActionResult> GetJobProfileById(int id)
        {
            try
            {
                var rsc = await _jobService.GetJobProfileById(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        // POST api/<JobController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JobController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        [Route("deleteJobProfile")]
        public async Task<IActionResult> DeleteJobProfile(int id)
        {
            try
            {
                await _jobService.RemoveJobProfile(id);
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
        [Route("deleteJobProfession")]
        public async Task<IActionResult> DeleteJobProfession(int id)
        {
            try
            {
                await _jobService.RemoveJobProfession(id);
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
        [Route("deleteJobSkillLevel")]
        public async Task<IActionResult> DeleteJobSkillLevel(int id)
        {
            try
            {
                await _jobService.RemoveJobSkillLevel(id);
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
        [Route("deleteSkillGrade")]
        public async Task<IActionResult> DeleteSkillGrade(int id)
        {
            try
            {
                await _jobService.RemoveSkillGrade(id);
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
        [Route("deleteVacancy")]
        public async Task<IActionResult> DeleteVacancy(int id)
        {
            try
            {
                await _jobService.RemoveVacancy(id);
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
