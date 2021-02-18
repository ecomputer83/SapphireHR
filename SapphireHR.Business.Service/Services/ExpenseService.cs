using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Data.Service.Repositories;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IMapper _mapper;
        private readonly ExpenseRespository _expenseRepository;
        public ExpenseService(ExpenseRespository expenseRepository, IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }
        public async Task AddExpenseClaim(ExpenseClaimModel model)
        {
            var datamodel = _mapper.Map<ExpenseClaim>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _expenseRepository.Add(datamodel);
        }

        public async Task AddExpenseType(ExpenseTypeModel model)
        {
            var datamodel = _mapper.Map<ExpenseType>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _expenseRepository.AddExpenseType(datamodel);
        }

        public async Task AddExpensePromotion(ExpensePromotionModel model)
        {
            var datamodel = _mapper.Map<ExpensePromotion>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await _expenseRepository.AddExpensePromotion(datamodel);
        }

        public async Task<ExpenseClaimModel> GetExpenseClaim(int id)
        {
            var claim = await _expenseRepository.Get(id);
            var res = _mapper.Map<ExpenseClaimModel>(claim);
            return res;
        }

        public async Task<List<ExpenseClaimModel>> GetExpenseClaims()
        {
            var claim = await _expenseRepository.GetAll();
            var res = _mapper.Map<List<ExpenseClaimModel>>(claim);
            return res;
        }

        public async Task<ExpensePromotionModel> GetExpensePromotion(int id)
        {
            var expensePromotion = await _expenseRepository.GetExpensePromotion(id);
            var res = _mapper.Map<ExpensePromotionModel>(expensePromotion);
            return res;
        }

        public async Task<List<ExpensePromotionModel>> GetExpensePromotions()
        {
            var expensePromotion = await _expenseRepository.GetExpensePromotions();
            var res = _mapper.Map<List<ExpensePromotionModel>>(expensePromotion);
            return res;
        }

        public async Task<ExpenseTypeModel> GetExpenseType(int id)
        {
            var expenseType = await _expenseRepository.GetExpenseType(id);
            var res = _mapper.Map<ExpenseTypeModel>(expenseType);
            return res;
        }

        public async Task<List<ExpenseTypeModel>> GetExpenseTypes()
        {
            var expenseType = await _expenseRepository.GetExpenseTypes();
            var res = _mapper.Map<List<ExpenseTypeModel>>(expenseType);
            return res;
        }

        public async Task RemoveExpenseClaim(int id)
        {
            await _expenseRepository.Delete(id);
        }

        public async Task RemoveExpensePromotion(int id)
        {
            await _expenseRepository.RemoveExpensePromotion(id);
        }

        public async Task RemoveExpenseType(int id)
        {
            await _expenseRepository.RemoveExpenseType(id);
        }

        public async Task UpdateExpenseClaim(ExpenseClaimModel model)
        {
            var datamodel = _mapper.Map<ExpenseClaim>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _expenseRepository.Update(datamodel);
        }

        public async Task UpdateExpensePromotion(ExpensePromotionModel model)
        {
            var datamodel = _mapper.Map<ExpensePromotion>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _expenseRepository.UpdateExpensePromotion(datamodel);
        }

        public async Task UpdateExpenseType(ExpenseTypeModel model)
        {
            var datamodel = _mapper.Map<ExpenseType>(model);
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.UpdatedBy = "SYSTEM";
            await _expenseRepository.UpdateExpenseType(datamodel);
        }
    }
}
