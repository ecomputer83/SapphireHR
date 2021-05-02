using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IPaymentService
    {
        Task AddSalaries(SalaryTransaction[] models, int id);
        Task<int> AddBatchSalary(RemitaSalaryRequest model, int id);
        Task<int> AddBatchPension(RemitaPensionRequest model, int id);
        Task AddPensions(PensionTransaction[] models, int id);
        Task<int> AddBatchTax(RemitaTaxRequest model, int id);
        Task AddTaxes(TaxTransaction[] models, int id);
    }
}
