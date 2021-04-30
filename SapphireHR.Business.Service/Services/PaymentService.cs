using AutoMapper;
using SapphireHR.Business.Abstractions;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Data.Service.Repositories;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IMapper _mapper;
        private readonly PaymentRepository _paymentRepository;

        public PaymentService(IMapper mapper, PaymentRepository paymentRepository)
        {
            _mapper = mapper;
            _paymentRepository = paymentRepository;
        }
        public async Task<int> AddBatchSalary(RemitaSalaryRequest model, int id)
        {
            var data = _mapper.Map<SalaryBatchPayment>(model);
            data.CompanyId = id;
            data.CreatedAt = DateTime.Now;
            data.CreatedBy = "SYSTEM";
            data = await _paymentRepository.Add(data);
            return data.Id;
        }

        public async Task AddSalaries(SalaryTransaction[] models, int id)
        {
            var data = _mapper.Map<SalaryPayment[]>(models);
            data = data.Select(c =>
            {
                var ret = c;
                ret.SalaryBatchPaymentId = id;
                return ret;
            }).ToArray();
            await _paymentRepository.AddSalaries(data);
        }

        public async Task<int> AddBatchPension(RemitaPensionRequest model, int id)
        {
            var data = _mapper.Map<PensionBatchPayment>(model);
            data.CompanyId = id;
            data.CreatedAt = DateTime.Now;
            data.CreatedBy = "SYSTEM";
            data = await _paymentRepository.AddBatchPension(data);
            return data.Id;
        }

        public async Task AddPensions(PensionTransaction[] models, int id)
        {
            var data = _mapper.Map<PensionPayment[]>(models);
            data = data.Select(c =>
            {
                var ret = c;
                ret.PensionBatchPaymentId = id;
                return ret;
            }).ToArray();
            await _paymentRepository.AddPensions(data);
        }

        public async Task<int> AddBatchTax(RemitaTaxRequest model, int id)
        {
            var data = _mapper.Map<TaxBatchPayment>(model);
            data.CompanyId = id;
            data.CreatedAt = DateTime.Now;
            data.CreatedBy = "SYSTEM";
            data = await _paymentRepository.AddBatchTax(data);
            return data.Id;
        }

        public async Task AddTaxes(TaxTransaction[] models, int id)
        {
            var data = _mapper.Map<TaxPayment[]>(models);
            data = data.Select(c =>
            {
                var ret = c;
                ret.TaxBatchPaymentId = id;
                return ret;
            }).ToArray();
            await _paymentRepository.AddTaxes(data);
        }
    }
}
