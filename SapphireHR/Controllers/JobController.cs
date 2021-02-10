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
        private readonly ILogger<JobController> _logger;

        public JobController(IJobService jobService, ILogger<JobController> logger)
        {
            _jobService = jobService;
            _logger = logger;
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> Post()
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
                await _jobService.AddJobProfile(model);
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [Route("createSkillGrade")]
        public async Task<IActionResult> PostSkillGrade([FromBody] SkillGradeModel model)
        {
            try
            {
                await _jobService.AddSkillGrade(model);
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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


        [Authorize(Roles = "Administrator")]
        [HttpPut]
        [Route("updateSkillGrade")]
        public async Task<IActionResult> UpdateSkillGrade([FromBody] SkillGradeModel model)
        {
            try
            {
                await _jobService.UpdateSkillGrade(model, model.Id);
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
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

        [Authorize(Roles = "Administrator")]
        [HttpDelete]
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
