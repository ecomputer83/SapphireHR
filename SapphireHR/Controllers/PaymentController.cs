using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SapphireHR.Business.Abstractions;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Business.Integrations;
using SapphireHR.Business.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SapphireHR.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : BaseApiController
    {
        PaymentClientService _paymentClientService;
        IEmployeeService _employeeService;
        ICompanyService _companyService;
        IPaymentService _paymentService;
        private readonly ILogger<PaymentController> _logger;
        public PaymentController(IOrganizationService organizationService, PaymentClientService paymentClientService,
            IEmployeeService employeeService, ICompanyService companyService, IPaymentService paymentService,
            ILogger<PaymentController> logger) : base(organizationService)
        {
            _paymentClientService = paymentClientService;
            _employeeService = employeeService;
            _companyService = companyService;
            _paymentService = paymentService;
            _logger = logger;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PaySalary(int id)
        {
            try
            {
                var salaries = await _employeeService.GetAllEmployeeSalaries(id);
                var banks = await _employeeService.GetEmployeeBanks(id);
                var settings = await _companyService.GetCompanyAccount(id);

                var login = await _paymentClientService.Authenticate(new RemitaLogin { username = settings.RemitaUserAccount, password = settings.RemitaSecret });

                if (login.status != "00")
                    throw new Exception("Remita credential is invalid");

                var batchRef = "bat" + new RandomGenerator().RandomNumber(4, 4) + DateTime.Now.ToString("ddMMyyyyHHmmss");
                var customRef = new RandomGenerator().RandomNumber(5, 10).ToString();

                var salaryTransactions = salaries.Join(banks,
                    x => x.EmployeeId,
                    y => y.EmployeeId,
                    (x, y) => new SalaryTransaction
                    {
                        Amount = x.NetSalary,
                        TransactionRef = x.Id + "E" + x.EmployeeId + new RandomGenerator().RandomNumber(6, 6),
                        DestinationAccount = y.BankAccountNumber,
                        DestinationBankCode = y.BankName,
                        DestinationNarration = "Salary Payment of " + x.SalaryDate.ToString("MMMM yyyy")
                    })
                      .ToList();

                var salaryRequest = new RemitaSalaryRequest
                {
                    BatchRef = batchRef,
                    TotalAmount = salaryTransactions.Sum(x => x.Amount),
                    SourceAccount = settings.BankAccountForSalary,
                    SourceBankCode = settings.BankCodeForSalary,
                    Currency = "NGN",
                    SourceNarration = "Salary Payment of " + DateTime.Now.ToString("MMMM yyyy"),
                    OriginalAccountNumber = settings.BankAccountForSalary,
                    OriginalBankCode = settings.BankCodeForSalary,
                    CustomReference = customRef,
                    Transactions = salaryTransactions
                };

                var resp = await _paymentClientService.PaySalary(salaryRequest, login.data.accessToken);

                if (resp.status == "00")
                {
                    var res = await _paymentService.AddBatchSalary(salaryRequest, id);
                    await _paymentService.AddSalaries(salaryTransactions.ToArray(), res);
                }
                else
                {
                    throw new Exception("Salary Payment failed");
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
        [HttpGet]
        public async Task<IActionResult> GetTaxOffice(int id)
        {
            try
            {
                var settings = await _companyService.GetCompanyAccount(id);
                var login = await _paymentClientService.Authenticate(new RemitaLogin { username = settings.RemitaUserAccount, password = settings.RemitaSecret });

                if (login.status != "00")
                    throw new Exception("Remita credential is invalid");

                var resp = await _paymentClientService.GetTaxCodes(login.data.accessToken);
                return Ok(resp.data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetPensionManager(int id)
        {
            try
            {
                var settings = await _companyService.GetCompanyAccount(id);
                var login = await _paymentClientService.Authenticate(new RemitaLogin { username = settings.RemitaUserAccount, password = settings.RemitaSecret });

                if (login.status != "00")
                    throw new Exception("Remita credential is invalid");

                var resp = await _paymentClientService.GetPensionCodes(login.data.accessToken);
                return Ok(resp.data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PayPension(int id, string Period)
        {
            try
            {
                var salaries = await _employeeService.GetEmployeeSalariesByMonth(id, Period);
                var pensions = await _employeeService.GetEmployeePensions(id);
                var settings = await _companyService.GetCompanyAccount(id);

                var login = await _paymentClientService.Authenticate(new RemitaLogin { username = settings.RemitaUserAccount, password = settings.RemitaSecret });

                if (login.status != "00")
                    throw new Exception("Remita credential is invalid");

                var batchRef = "bat" + new RandomGenerator().RandomNumber(4, 4) + DateTime.Now.ToString("ddMMyyyyHHmmss");
                //var customRef = new RandomGenerator().RandomNumber(5, 10).ToString();
                var sp = Period.Split('/');
                var TransPeriod = sp[1] + sp[0];

                var pensionTransactions = salaries.Join(pensions,
                    x => x.EmployeeId,
                    y => y.EmployeeId,
                    (x, y) => new PensionTransaction
                    {
                        Amount = x.PF + (x.Basic * 0.1),
                        TransactionRef = x.Id + "E" + x.EmployeeId + new RandomGenerator().RandomNumber(6, 6),
                        BeneficiarySurname = x.Employee.FirstName,
                        BeneficiaryOtherName = x.Employee.LastName,
                        Company = settings.CompanyInfo.Name,
                        EmployeeContribution = x.PF,
                        EmployerContribution = x.Basic * 0.1,
                        PfaPin = y.PensionNo,
                        PfaCode = y.PensionManager,
                        Email = x.Employee.Email,
                        Phone = x.Employee.Phone,
                        CustomerId = settings.CompanyInfo.Abbrv + x.Employee.Id,
                        EmployerCode = settings.EmployerCodeForPension,
                        TransactionMonth = TransPeriod,
                        Period = TransPeriod
                    })
                      .ToList();

                var pensionRequest = new RemitaPensionRequest
                {
                    BatchRef = batchRef,
                    TotalAmount = pensionTransactions.Sum(x => x.Amount),
                    SourceAccount = settings.BankAccountForSalary,
                    SourceBankCode = settings.BankCodeForSalary,
                    Details = pensionTransactions
                };

                var resp = await _paymentClientService.PayPension(pensionRequest, login.data.accessToken);

                if (resp.status == "00")
                {
                    var res = await _paymentService.AddBatchPension(pensionRequest, id);
                    await _paymentService.AddPensions(pensionTransactions.ToArray(), res);
                }
                else
                {
                    throw new Exception("Pension Payment failed");
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
        [HttpPost]
        public async Task<IActionResult> PayTax(int id, string Period)
        {
            try
            {
                var salaries = await _employeeService.GetEmployeeSalariesByMonth(id, Period);
                var taxes = await _employeeService.GetEmployeeTaxes(id);
                var settings = await _companyService.GetCompanyAccount(id);

                var login = await _paymentClientService.Authenticate(new RemitaLogin { username = settings.RemitaUserAccount, password = settings.RemitaSecret });

                if (login.status != "00")
                    throw new Exception("Remita credential is invalid");

                var batchRef = "bat" + new RandomGenerator().RandomNumber(4, 4) + DateTime.Now.ToString("ddMMyyyyHHmmss");
                //var customRef = new RandomGenerator().RandomNumber(5, 10).ToString();
                var sp = Period.Split('/');
                var TransPeriod = sp[1] + sp[0];

                var taxTransactions = salaries.Join(taxes,
                    x => x.EmployeeId,
                    y => y.EmployeeId,
                    (x, y) => new TaxTransaction
                    {
                        TaxAmount = x.Tax,
                        TransactionRef = x.Id + "E" + x.EmployeeId + new RandomGenerator().RandomNumber(6, 6),
                        StaffName = x.Employee.FirstName + " " + x.Employee.LastName,
                        Company = settings.CompanyInfo.Name,
                        BeneficiaryName = y.TaxOffice,
                        Tin = y.Tin,
                        TaxState = y.TaxCode,
                        Phone = x.Employee.Phone,
                        StaffNumber = settings.CompanyInfo.Abbrv + x.Employee.Id,
                        EmployeeCode = settings.CompanyInfo.Abbrv + x.Employee.Id,
                        TransactionMonth = TransPeriod,
                        Period = TransPeriod
                    })
                      .ToList();

                var taxRequest = new RemitaTaxRequest
                {
                    BatchRef = batchRef,
                    TotalAmount = taxTransactions.Sum(x => x.TaxAmount),
                    SourceAccount = settings.BankAccountForSalary,
                    SourceBankCode = settings.BankCodeForSalary,
                    Details = taxTransactions
                };

                var resp = await _paymentClientService.PayTax(taxRequest, login.data.accessToken);

                if (resp.status == "00")
                {
                    var res = await _paymentService.AddBatchTax(taxRequest, id);
                    await _paymentService.AddTaxes(taxTransactions.ToArray(), res);
                }
                else
                {
                    throw new Exception("Tax Payment failed");
                }

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
