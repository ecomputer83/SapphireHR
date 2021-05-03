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
    public class EmployeeController : BaseApiController
    {
        IEmployeeService _employeeService;
        IUserService _userService;
        IOrganizationService _organizationService;
        IMiscellaneousService _miscellaneousService;
        private IEmailService _emailService;
        private ICompanyService _companyService;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeService employeeService, IUserService userService,
            IOrganizationService organizationService, IMiscellaneousService miscellaneousService,
            ILogger<EmployeeController> logger, IEmailService emailService, ICompanyService companyService) : base(organizationService)
        {
            _employeeService = employeeService;
            _userService = userService;
            _organizationService = organizationService;
            _miscellaneousService = miscellaneousService;
            _emailService = emailService;
            _companyService = companyService;
            _logger = logger;
        }


        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployee(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }
        
        [Authorize]
        [HttpGet("{companyId}")]
        public async Task<IActionResult> GetAllEmployees(int companyId)
        {
            try
            {
                var rsc = await _employeeService.GetAllEmployees(companyId);
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
        public async Task<IActionResult> GetEmployeeBank(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeBank(id);
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
        public async Task<IActionResult> GetEmployeeResignation(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeResignation(id);
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
        public async Task<IActionResult> GetEmployeeResignations(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeResignations(id);
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
        public async Task<IActionResult> GetEmployeeTermination(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeTermination(id);
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
        public async Task<IActionResult> GetEmployeeTerminations(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeTerminations(id);
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
        public async Task<IActionResult> GetEmployeeEducation(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeEducation(id);
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
        public async Task<IActionResult> GetEmployeeEmergency(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeEmergency(id);
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
        public async Task<IActionResult> GetEmployeExperience(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeExp(id);
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
        public async Task<IActionResult> GetEmployeeFamily(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeFamily(id);
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
        public async Task<IActionResult> GetEmployeeLeave(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEMployeeLeave(id);
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
        public async Task<IActionResult> GetEmployeeLeaves(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeLeaves(id);
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
        public async Task<IActionResult> GetEmployeePension(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeePension(id);
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
        public async Task<IActionResult> GetEmployeeTax(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeTax(id);
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
        public async Task<IActionResult> GetEmployeeStatutory(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeStatutory(id);
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
        public async Task<IActionResult> GetEmployeeSalary(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeSalary(id);
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
        public async Task<IActionResult> GetPaidSalaries(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeePayslip(id);
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
        public async Task<IActionResult> GetAllEmployeeSalaries(int id)
        {
            try
            {
                var rsc = await _employeeService.GetAllEmployeeSalaries(id);
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
        public async Task<IActionResult> GetAllPrevEmployeeSalaries(int id, string month, string year)
        {
            try
            {
                var period = month + '/' + year;
                var rsc = await _employeeService.GetEmployeeSalariesByMonth(id, period);
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
        public async Task<IActionResult> GetMonthlyAAttendanceReview(int id, string month, string year)
        {
            try
            {
                var period = month + '/' + year;
                var rsc = await _employeeService.GetMonthlyAttendanceReview(id, period);
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
        public async Task<IActionResult> GetEmployeeTimetable(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeTimetable(id);
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
        public async Task<IActionResult> GetEmployeeTransfer(int id)
        {
            try
            {
                var rsc = await _employeeService.GetEmployeeTransfer(id);
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
        public async Task<IActionResult> GetDisciplinaryMeasure(int id)
        {
            try
            {
                var rsc = await _employeeService.GetDisciplinaryMeasure(id);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet("{companyId}")]
        public async Task<IActionResult> GetDisciplinaryMeasures(int companyId)
        {
            try
            {
                var rsc = await _employeeService.GetDisciplinaryMeasures(companyId);
                return Ok(rsc);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        public async Task<IActionResult> PostEmployee([FromBody] EmployeeModel payload)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }

                var host = Request.Headers["Holder"];
                var company = await _companyService.GetCompany(payload.CompanyId);

                var model = new UserModel();
                model.OrganizationId = org.Id;
                model.FullName = $"{payload.FirstName} {payload.LastName}";
                model.Email = payload.Email;
                model.PhoneNumber = payload.Phone;
                model.UserType = 3;
                model.Password = "password";
                model.ConfirmPassword = "password";
                var usermodel = await _userService.CreateUserAsync(model, new string[] { "Employee" });
                payload.UserId = usermodel.Id;
                var new_emp = await _employeeService.AddEmployee(payload);
                var emp = await _employeeService.GetEmployee(new_emp.Id);
                await _emailService.SendEmployeeMessageAsync(host, company.Name, emp.Designation.Name, model);
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
        public async Task<IActionResult> PostHR([FromBody] EmployeeModel payload)
        {
            try

            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }

                var host = Request.Headers["Holder"];
                var company = await _companyService.GetCompany(payload.CompanyId);

                //add rank
                var rankId = 0;
                var rank = await _organizationService.GetRank(org.Id, "Resources Manager");
                if (rank == null)
                {
                    var rmodel = new RankModel
                    {
                        RankName = "Resources Manager",
                        OrganizationId = org.Id,
                        RankPermission = new RankPermissionModel
                        {
                            WriteAssets = true,
                            ReadAssets = true,
                            DeleteAssets = true,
                            WriteHolidays = true,
                            ReadHoliday = true,
                            DeleteHolidays = true,
                            WriteLeave = true,
                            ReadLeave = true,
                            DeleteLeave = true,
                            WriteTimesheet = true,
                            ReadTimesheet = true,
                            DeleteTimesheet = true
                        }
                    };
                    rankId = await _organizationService.AddRank(rmodel);
                }
                else
                {
                    rankId = rank.Id;
                }

                //add department
                var departmentId = 0;
                var department = await _miscellaneousService.GetDepartment("Human Resources");
                if (department == null)
                {
                    var dpmodel = new DepartmentModel
                    {
                        OrganizationId = org.Id,
                        Name = "Human Resources"
                    };
                    departmentId = await _miscellaneousService.AddDepartment(dpmodel);
                }
                else
                {
                    departmentId = department.Id;
                }
                //add designation
                var designationId = 0;
                var designation = await _miscellaneousService.GetDesignation("HR Manager");
                if (designation == null)
                {
                    var dmodel = new DesignationModel
                    {
                        OrganizationId = org.Id,
                        DepartmentId = departmentId,
                        Name = "HR Manager"
                    };
                    designationId = await _miscellaneousService.AddDesignation(dmodel);
                }
                else
                {
                    designationId = designation.Id;
                }
                var model = new UserModel();
                model.OrganizationId = org.Id;
                model.FullName = $"{payload.FirstName} {payload.LastName}";
                model.Email = payload.Email;
                model.PhoneNumber = payload.Phone;
                model.UserType = 2;
                model.Password = "password";
                model.ConfirmPassword = "password";
                var usermodel = await _userService.CreateUserAsync(model, new string[] { "HRAdmin" });
                payload.UserId = usermodel.Id;
                payload.RankId = rankId;
                payload.DesignationId = designationId;
                var emp = await _employeeService.AddEmployee(payload);

                await _emailService.SendHRMessageAsync(host, company.Name, model);
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
        public async Task<IActionResult> PostEmployeeBank([FromBody] EmployeeBankModel payload)
        {            
            try

            {
                await _employeeService.AddEmployeeBank(payload);
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
        public async Task<IActionResult> PostEmployeeTravel([FromBody] EmployeeTravelModel payload)
        {
            try

            {
                await _employeeService.AddEmployeeTravel(payload);
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
        public async Task<IActionResult> PostEmployeeResignation([FromBody] EmployeeResignationModel payload)
        {
            try

            {
                await _employeeService.AddEmployeeResignation(payload);
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
        public async Task<IActionResult> PostEmployeeTermination([FromBody] EmployeeTerminationModel payload)
        {
            try

            {
                await _employeeService.AddEmployeeTermination(payload);
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
        public async Task<IActionResult> PostEmployeeEducation([FromBody] EmployeeEducationModel payload)
        {
            try
            {
                await _employeeService.AddEmployeeEducation(payload);
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
        public async Task<IActionResult> PostEmployeeEmergency([FromBody] EmployeeEmergencyModel payload)
        {
            try
            {
                await _employeeService.AddEmployeeEmergency(payload);
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
        public async Task<IActionResult> PostEmployeeExp([FromBody] EmployeeExperienceModel payload)
        {
            try
            {
                await _employeeService.AddEmployeeExp(payload);
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
        public async Task<IActionResult> PostEmployeeStatutory([FromBody] EmployeeStatutoryModel payload)
        {
            try
            {
                await _employeeService.AddEmployeeStatutory(payload);
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
        public async Task<IActionResult> PostDisciplinaryMeasure([FromBody] DisciplinaryMeasuresModel payload)
        {
            try
            {
                await _employeeService.AddDisciplinaryMeasures(payload);
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
        public async Task<IActionResult> PostEmployeeFamily([FromBody] EmployeeFamilyModel payload)
        {
            try
            {
                await _employeeService.AddEmployeeFamily(payload);
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
        public async Task<IActionResult> PostEmployeeLeave([FromBody] EmployeeLeaveModel payload)
        {
            try
            {
                await _employeeService.AddEmployeeLeave(payload);
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
        public async Task<IActionResult> PostEmployeeSalary([FromBody] EmployeeSalaryModel payload)
        {
            try
            {
                await _employeeService.AddEmployeeSalary(payload);
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
        public async Task<IActionResult> PostEmployeePension([FromBody] EmployeePensionModel payload)
        {
            try
            {
                await _employeeService.AddEmployeePension(payload);
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
        public async Task<IActionResult> PostEmployeeTax([FromBody] EmployeeTaxModel payload)
        {
            try
            {
                await _employeeService.AddEmployeeTax(payload);
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
        public async Task<IActionResult> PostEmployeeTimetable([FromBody] EmployeeTimetableModel payload)
        {
            try
            {
                await _employeeService.AddEmployeeTimetable(payload);
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
        public async Task<IActionResult> PostEmployeeTransfer([FromBody] EmployeeTransferModel payload)
        {
            try
            {
                await _employeeService.AddEmployeeTransfer(payload);
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
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployee(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeBank(int id, [FromBody] EmployeeBankModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeBank(payload, id);
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
        public async Task<IActionResult> UpdateDisciplinaryMeasure(int id, [FromBody] DisciplinaryMeasuresModel payload)
        {
            try
            {
                await _employeeService.UpdateDisciplinaryMeasures(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeEducation(int id, [FromBody] EmployeeEducationModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeEducation(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeEmergency(int id, [FromBody] EmployeeEmergencyModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeEmergency(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeResignation(int id, [FromBody] EmployeeResignationModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeResignation(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeTermination(int id, [FromBody] EmployeeTerminationModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeTermination(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeTravel(int id, [FromBody] EmployeeTravelModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeTravel(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeExperience(int id, [FromBody] EmployeeExperienceModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeExp(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeFamily(int id, [FromBody] EmployeeFamilyModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeFamily(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeLeave(int id, [FromBody] EmployeeLeaveModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeLeave(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeSalary(int id, [FromBody] EmployeeSalaryModel data)
        {
            try
            {
                await _employeeService.UpdateEmployeeSalary(data, id);
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
        public async Task<IActionResult> UpdateEmployeePension(int id, [FromBody] EmployeePensionModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeePension(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeTax(int id, [FromBody] EmployeeTaxModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeTax(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeStatutory(int id, [FromBody] EmployeeStatutoryModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeStatutory(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeTimetable(int id, [FromBody] EmployeeTimetableModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeTimetable(payload, id);
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
        public async Task<IActionResult> UpdateEmployeeTransfer(int id, [FromBody] EmployeeTransferModel payload)
        {
            try
            {
                await _employeeService.UpdateEmployeeTransfer(payload, id);
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
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            try
            {
                var employee = await _employeeService.GetNoTrackingEmployee(id);
                if (employee != null)
                {
                    await _employeeService.RemoveEmployee(id);

                    if (!string.IsNullOrEmpty(employee.UserId))
                    {
                        await _userService.RemoveUser(employee.UserId);
                    }
                    
                    
                }
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
        public async Task<IActionResult> DeleteEmployeeBank(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeBank( id);
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
        public async Task<IActionResult> DeleteEmployeeSalary(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeSalary(id);
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
        public async Task<IActionResult> DeleteEmployeeResignation(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeResignation(id);
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
        public async Task<IActionResult> DeleteDisciplinaryMeasure(int id)
        {
            try
            {
                await _employeeService.RemoveDisciplinaryMeasures(id);
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
        public async Task<IActionResult> DeleteEmployeeTermination(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeTermination(id);
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
        public async Task<IActionResult> DeleteEmployeeTravel(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeTravel(id);
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
        public async Task<IActionResult> DeleteEmployeeFamily(int id)
        {
            try
            {
                await _employeeService.RemoveEMployeeFamily(id);
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
        public async Task<IActionResult> DeleteEmployeeLeave(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeLeave(id);
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
        public async Task<IActionResult> DeleteEmployeePension(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeePension(id);
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
        public async Task<IActionResult> DeleteEmployeeStatutory(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeStatutory(id);
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
        public async Task<IActionResult> DeleteEmployeeTimetable(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeTimetable(id);
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
        public async Task<IActionResult> DeleteEmployeeTransfer(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeTransfer(id);
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
        public async Task<IActionResult> DeleteEmployeeEducation(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeEducation(id);
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
        public async Task<IActionResult> DeleteEmployeeEmergency(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeEmergency(id);
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
        public async Task<IActionResult> DeleteEmployeeExperience(int id)
        {
            try
            {
                await _employeeService.RemoveEmployeeExp(id);
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
