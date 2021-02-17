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
    public class SkillController : BaseApiController
    {
        ISkillService _skillService;
        IOrganizationService _organizationService;
        private readonly ILogger<SkillController> _logger;

        public SkillController(ISkillService skillService, IOrganizationService organizationService, ILogger<SkillController> logger) : base(organizationService)
        {
            _skillService = skillService;
            _organizationService = organizationService;
            _logger = logger;
        }


        //[Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("getSkillGradeById")]
        public async Task<IActionResult> GetSkillGradeById(int id)
        {
            try
            {
                var rsc = await _skillService.GetSkillGradeById(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }


        //[Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("getSkillById")]
        public async Task<IActionResult> GetSkillById(int id)
        {
            try
            {
                var rsc = await _skillService.GetSkillById(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }


        //[Authorize(Roles = "Administrator")]
        [HttpGet]
        [Route("getSkillTypeById")]
        public async Task<IActionResult> GetSkillTypeById(int id)
        {
            try
            {
                var rsc = await _skillService.GetSkillTypeById(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }


//        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getSkillGrades")]
        public async Task<IActionResult> GetSkillGrades()
        {
            try
            {
                var resource = await _skillService.GetSkillGrades();
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

//        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getSkills")]
        public async Task<IActionResult> GetSkills()
        {
            try
            {
                var resource = await _skillService.GetSkills();
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

//        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getSkillTypes")]
        public async Task<IActionResult> GetSkillTypes()
        {
            try
            {
                var resource = await _skillService.GetSkillTypes();
                return Ok(resource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }



//        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateSkillGrade")]
        public async Task<IActionResult> UpdateSkillGrade([FromBody] SkillGradeModel model)
        {
            try
            {
                await _skillService.UpdateSkillGrade(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

//        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateSkill")]
        public async Task<IActionResult> UpdateSkill([FromBody] SkillModel model)
        {
            try
            {
                await _skillService.UpdateSkill(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

//        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateSkillType")]
        public async Task<IActionResult> UpdateSkillType([FromBody] SkillTypeModel model)
        {
            try
            {
                await _skillService.UpdateSkillType(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

//        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        [Route("createSkillGrade")]
        public async Task<IActionResult> PostSkillGrade([FromBody] SkillGradeModel model)
        {
            try
            {
                await _skillService.AddSkillGrade(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

//        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        [Route("createSkill")]
        public async Task<IActionResult> PostSkill([FromBody] SkillModel model)
        {
            try
            {
                await _skillService.AddSkill(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

//        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        [Route("createSkillType")]
        public async Task<IActionResult> PostSkillType([FromBody] SkillTypeModel model)
        {
            try
            {
                await _skillService.AddSkillType(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }


//        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
        [Route("deleteSkillGrade")]
        public async Task<IActionResult> DeleteSkillGrade(int id)
        {
            try
            {
                await _skillService.RemoveSkillGrade(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

//        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
        [Route("deleteSkill")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            try
            {
                await _skillService.RemoveSkill(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

//        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
        [Route("deleteSkillType")]
        public async Task<IActionResult> DeleteSkillType(int id)
        {
            try
            {
                await _skillService.RemoveSkillType(id);
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
