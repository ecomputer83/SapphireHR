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
    public class ExpenseController : BaseApiController
    {
        IOrganizationService _organizationService;
        IExpenseService _expenseService;
        private readonly ILogger<ExpenseController> _logger;

        public ExpenseController(IOrganizationService organizationService, ILogger<ExpenseController> logger, IExpenseService expenseService): base(organizationService)
        {
            _organizationService = organizationService;
            _expenseService = expenseService;
        }
        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExpenseClaim(int id)
        {
            try
            {
                var rsc = await _expenseService.GetExpenseClaim(id);
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
        public async Task<IActionResult> GetPromotion(int id)
        {
            try
            {
                var rsc = await _expenseService.GetExpensePromotion(id);
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
        public async Task<IActionResult> GetPromotions(int id)
        {
            try
            {
                var rsc = await _expenseService.GetExpensePromotions(id);
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
        public async Task<IActionResult> GetExpenseType(int id)
        {
            try
            {
                var rsc = await _expenseService.GetExpenseType(id);
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
        public async Task<IActionResult> PostExpenseClaim([FromBody] ExpenseClaimModel payload)
        {
            try
            {
                await _expenseService.AddExpenseClaim(payload);
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
        public async Task<IActionResult> PostExpenseType([FromBody] ExpenseTypeModel payload)
        {
            try
            {
                await _expenseService.AddExpenseType(payload);
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
        public async Task<IActionResult> PostExpensePromotion([FromBody] ExpensePromotionModel payload)
        {
            try
            {
                await _expenseService.AddExpensePromotion(payload);
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
        public async Task<IActionResult> PutExpensePromotion([FromBody] ExpensePromotionModel payload)
        {
            try
            {
                await _expenseService.UpdateExpensePromotion(payload);
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
        public async Task<IActionResult> PutExpenseType([FromBody] ExpenseTypeModel payload)
        {
            try
            {
                await _expenseService.UpdateExpenseType(payload);
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
        public async Task<IActionResult> PutExpenseClaim([FromBody] ExpenseClaimModel payload)
        {
            try
            {
                await _expenseService.UpdateExpenseClaim(payload);
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
        public async Task<IActionResult> DeleteExpenseClaim(int id)
        {
            try
            {
                await _expenseService.RemoveExpenseClaim(id);
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
        public async Task<IActionResult> DeleteExpensePromotion(int id)
        {
            try
            {
                await _expenseService.RemoveExpensePromotion(id);
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
        public async Task<IActionResult> DeleteExpenseType(int id)
        {
            try
            {
                await _expenseService.RemoveExpenseType(id);
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
