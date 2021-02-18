using SapphireHR.Business.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Abstractions.Service
{
    public interface IExpenseService
    {
        Task<List<ExpenseClaimModel>> GetExpenseClaims();
        Task<ExpenseClaimModel> GetExpenseClaim(int id);
        Task AddExpenseClaim(ExpenseClaimModel model);
        Task UpdateExpenseClaim(ExpenseClaimModel model);
        Task RemoveExpenseClaim(int id);


        Task<List<ExpenseTypeModel>> GetExpenseTypes();
        Task<ExpenseTypeModel> GetExpenseType(int id);
        Task AddExpenseType(ExpenseTypeModel model);
        Task UpdateExpenseType(ExpenseTypeModel model);
        Task RemoveExpenseType(int id);


        Task<List<ExpensePromotionModel>> GetExpensePromotions();
        Task<ExpensePromotionModel> GetExpensePromotion(int id);
        Task AddExpensePromotion(ExpensePromotionModel model);
        Task UpdateExpensePromotion(ExpensePromotionModel model);
        Task RemoveExpensePromotion(int id);
    }
}
