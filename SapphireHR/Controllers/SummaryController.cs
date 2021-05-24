using Microsoft.AspNetCore.Authorization;
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
    public class SummaryController : BaseApiController
    {
        IEmployeeService _employeeService;
        IUserService _userService;
        IOrganizationService _organizationService;
        IApplicationService _applicationService;
        IJobService _jobService;
        IMiscellaneousService _miscellaneousService;
        private IEmailService _emailService;
        private ICompanyService _companyService;
        private readonly ILogger<SummaryController> _logger;

        public SummaryController(IEmployeeService employeeService, IUserService userService,
            IOrganizationService organizationService, IMiscellaneousService miscellaneousService,
            IApplicationService applicationService, IJobService jobService,
            ILogger<SummaryController> logger, IEmailService emailService, ICompanyService companyService) : base(organizationService)
        {
            _employeeService = employeeService;
            _userService = userService;
            _organizationService = organizationService;
            _miscellaneousService = miscellaneousService;
            _applicationService = applicationService;
            _jobService = jobService;
            _emailService = emailService;
            _companyService = companyService;
            _logger = logger;
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeLeaveSummaryByEmployee(int id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }

                var leaveTypes = await _organizationService.GetLeaveTypes(org.Id);
                var result = new List<LeaveTypeSummaryModel>();
                foreach (var type in leaveTypes)
                {
                    var model = new LeaveTypeSummaryModel();
                    model.TypeId = type.Id;
                    model.LeaveTypeName = type.Name;
                    var company = await _employeeService.GetCompanyEmployee(id);
                    var setting = await _companyService.GetLeaveSettingByType(type.Id, company.CompanyId);
                    var policy = await _employeeService.GetEmployeeLeavePolicy(id, type.Id);
                    var usedLeaves = await _employeeService.GetEmployeeLeavesByTypeId(id, type.Id);

                    var useddays = usedLeaves.Sum(c => c.Days);

                    var leaveDays = (policy?.LeavePolicy?.Days != null)
                        ? policy.LeavePolicy.Days : (setting?.Days != null)
                        ? setting.Days : 0;

                    var remainingDays = leaveDays - useddays;

                    model.Used = useddays;
                    model.Eligible = leaveDays;
                    result.Add(model);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodayAbsence(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeLeavesSummaries(id, true);
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
        public async Task<IActionResult> GetUpcomingLeaves(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeLeavesSummaries(id, false);
                rsc = rsc.OrderBy(c => c.Status).Take(2).ToList();
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
        public async Task<IActionResult> GetUpcomingResignations(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeResignations(id);
                rsc = rsc.OrderBy(c => c.Status).Take(2).ToList();
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
        public async Task<IActionResult> GetDashboardCountSummary(int id)
        {
            try
            {
                var model = new DashboardCountModel();
                model.TotalEmployees = await _employeeService.GetTotalEmployees(id);
                model.TotalApplications = await _applicationService.GetAllApplicationCount(id);
                var prevDate = DateTime.Now.AddMonths(-1);
                var rsc = await _employeeService.GetAllEmployeeSalaries(id);
                var prev = await _employeeService.GetEmployeeSalariesByMonth(id, prevDate.Month.ToString() + '/' + prevDate.Year.ToString());
                if (rsc.Count > 0)
                {
                    model.TotalSalaries = rsc.Sum(c => c.NetSalary);
                }
                if(prev.Count > 0)
                {
                    model.TotalPrevSalaries = prev.Sum(c => c.NetSalary);
                }
                return Ok(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLeaveCountSummary(int id)
        {
            try
            {
                var model = new LeaveCountModel();
                model.TotalEmployees = await _employeeService.GetTotalEmployees(id);
                model.TotalPendingLeave = await _employeeService.GetTotalPendingLeaves(id);

                var rsc = await _employeeService.GetEmployeeLeavesSummaries(id, true);
                if (rsc.Count > 0)
                {
                    model.TotalAbsence = rsc.Count;
                }
                return Ok(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTotalApplications(int id)
        {
            try
            {
                var rsc = await _applicationService.GetAllApplicationCount(id);
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
        public async Task<IActionResult> GetTotalSalaries(int id)
        {
            try
            {
                double result = 0;
                var rsc = await _employeeService.GetAllEmployeeSalaries(id);
                if(rsc.Count > 0)
                {
                    result = rsc.Sum(c => c.NetSalary);
                }
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLastSalaryPayment(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeePaidSalaries(id);
                rsc = rsc.Where(c=>c.SalaryPayment != null).OrderByDescending(o => o.SalaryDate).Take(3).ToList();
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
    }
}
