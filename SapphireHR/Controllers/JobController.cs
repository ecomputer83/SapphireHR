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
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : BaseApiController
    {
        IJobService _jobService;
        IOrganizationService _organizationService;
        private readonly ILogger<JobController> _logger;

        public JobController(IJobService jobService, IOrganizationService organizationService, ILogger<JobController> logger) : base(organizationService)
        {
            _jobService = jobService;
            _organizationService = organizationService;
            _logger = logger;
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]

        public async Task<IActionResult> GetJobProfiles(int id)
        {
            try
            {
                var resource = await _jobService.GetJobProfiles(id);
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
        public async Task<IActionResult> Get(int Id)
        {
            try
            {
                var resource = await _jobService.GetJobProfileById(Id);
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

        [Authorize(Roles = "HRAdmin")]
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
        [Route("getVacancies")]
        public async Task<IActionResult> GetVacancies(int id)
        {
            try
            {
                var resource = await _jobService.GetVacancies(id);
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
        [HttpGet]
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
        [HttpGet]
        [Route("GetJobProfessionById")]
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
        [HttpGet]
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

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] JobProfileModel model)
        {
            try
            {
                var id = await _jobService.AddJobProfile(model);
                return Ok(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        [Route("createJobProfession")]
        public async Task<IActionResult> PostJobProfession([FromBody] JobProfessionModel model)
        {
            try
            {
                await _jobService.AddJobProfession(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        [Route("createJobSkillLevel")]
        public async Task<IActionResult> PostJobSkillLevel([FromBody] JobSkillLevelModel model)
        {
            try
            {
                await _jobService.AddJobSkillLevel(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        
        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        [Route("createVacancy")]
        public async Task<IActionResult> PostVacancy([FromBody] VacancyModel model)
        {
            try
            {
                await _jobService.AddVacancy(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateVacancy")]
        public async Task<IActionResult> UpdateVacancy([FromBody] VacancyModel model)
        {
            try
            {
                await _jobService.UpdateVacancy(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] JobProfileModel model)
        {
            try
            {
                await _jobService.UpdateJobProfile(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateJobProfession")]
        public async Task<IActionResult> UpdateJobProfession([FromBody] JobProfessionModel model)
        {
            try
            {
                await _jobService.UpdateJobProfession(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateJobSkillLevel")]
        public async Task<IActionResult> UpdateJobSkillLevel([FromBody] JobSkillLevelModel model)
        {
            try
            {
                await _jobService.UpdateJobSkillLevel(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }


        


        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
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

        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
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

        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
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

        
        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
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
