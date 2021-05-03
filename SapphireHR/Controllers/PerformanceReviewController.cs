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
        private readonly IEmployeePerfomanceAppraisal _employeePerfomanceAppraisal;
        public PerformanceReviewController(IOrganizationService organizationService, IPerformanceReviewService performanceReviewService, ILogger<PerformanceReviewController> logger, IEmployeePerfomanceAppraisal employeePerfomanceAppraisal) : base(organizationService)
        {
            _organizationService = organizationService;
            _performanceReviewService = performanceReviewService;
            _logger = logger;
            _employeePerfomanceAppraisal = employeePerfomanceAppraisal;
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
        [HttpPost]
        public async Task<IActionResult> AddEmployeeProffesionalExcellence([FromBody] EmployeeProffesionalExcellenceModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.AddEmployeeProffesionalExcellence(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeePersonalExcellence([FromBody] EmployeePersonalExcellenceModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeePersonalExcellence(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeeTrainingRequirement([FromBody] EmployeeTrainingRequirementModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeeTrainingRequirement(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeeObservation([FromBody] EmployeeObservationModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeeObservation(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeeInitiativeAchievement([FromBody] EmployeeInitiativeAchievementModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeeInitiativeAchievement(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeePersonalGoals([FromBody] EmployeePersonalGoalsModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeePersonalGoals(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeeProfGoalAchieved([FromBody] EmployeeProfGoalAchievedModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeeProfGoalAchieved(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeeProfGoalPlan([FromBody] EmployeeProfGoalPlanModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeeProfGoalPlan(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeeRoleComment([FromBody] EmployeeRoleCommentModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeeRoleComment(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeeResponsibilityComment([FromBody] EmployeeResponsibilityCommentModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeeResponsibilityComment(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeeHODImprovementComment([FromBody] EmployeeHODImprovementCommentModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeeHODImprovementComment(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddEmployeeROImprovementComment([FromBody] EmployeeROImprovementCommentModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));
                await _performanceReviewService.AddEmployeeROImprovementComment(model);

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

                var settings = await _performanceReviewService.GetPersonalExcellenceSettings(id);

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

                var settings = await _performanceReviewService.GetProffesionalExcellenceSettings(id);

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
        public async Task<IActionResult> GetPerformanceReview(int id)
        {
            try
            {

                var settings = await _performanceReviewService.GetPerformanceReview(id);

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
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployeePersonalExcellence([FromBody] EmployeePersonalExcellenceModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeePersonalExcellence(model, id);

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
        public async Task<IActionResult> UpdateEmployeeProffesionalExcellence([FromBody] EmployeeProffesionalExcellenceModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeeProffesionalExcellence(model, id);

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
        public async Task<IActionResult> UpdateEmployeeTrainingRequirement([FromBody] EmployeeTrainingRequirementModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeeTrainingRequirement(model, id);

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
        public async Task<IActionResult> UpdateEmployeeObservation([FromBody] EmployeeObservationModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeeObservation(model, id);

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
        public async Task<IActionResult> UpdateEmployeeInitiativeAchievement([FromBody] EmployeeInitiativeAchievementModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeeInitiativeAchievement(model, id);

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
        public async Task<IActionResult> UpdatEmployeePersonalGoals([FromBody] EmployeePersonalGoalsModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdatEmployeePersonalGoals(model, id);

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
        public async Task<IActionResult> UpdateEmployeeProfGoalAchieved([FromBody] EmployeeProfGoalAchievedModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeeProfGoalAchieved(model, id);

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
        public async Task<IActionResult> UpdateEmployeeProfGoalPlan([FromBody] EmployeeProfGoalPlanModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeeProfGoalPlan(model, id);

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
        public async Task<IActionResult> UpdateEmployeeRoleComment([FromBody] EmployeeRoleCommentModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeeRoleComment(model, id);

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
        public async Task<IActionResult> UpdateEmployeeResponsibilityComment([FromBody] EmployeeResponsibilityCommentModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeeResponsibilityComment(model, id);

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
        public async Task<IActionResult> UpdateEmployeeHODImprovementComment([FromBody] EmployeeHODImprovementCommentModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeeHODImprovementComment(model, id);

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
        public async Task<IActionResult> UpdateEmployeeROImprovementComment([FromBody] EmployeeROImprovementCommentModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.Values.Select(x => x.Errors.FirstOrDefault().ErrorMessage));

                await _performanceReviewService.UpdateEmployeeROImprovementComment(model, id);

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
        public async Task<IActionResult> RemovePerformanceReview(int id)
        {
            try
            {
                await _performanceReviewService.RemovePerformanceReview(id);
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
