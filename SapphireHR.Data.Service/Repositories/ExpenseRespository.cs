using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class ExpenseRespository : GenericRepository<SapphireHR.Database.EntityModels.ExpenseClaim, ApplicationDbContext>
    {
        public ExpenseRespository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task AddExpenseType(ExpenseType model)
        {
            _context.Set<ExpenseType>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task AddExpensePromotion(ExpensePromotion model)
        {
            _context.Set<ExpensePromotion>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task<ExpenseType> GetExpenseType(int id)
        {
            return await _context.Set<ExpenseType>()
               .Include(c => c.ExpenseClaim)
               .FirstOrDefaultAsync(s => s.Id == id);
        }
        public async Task<ExpensePromotion> GetExpensePromotion(int id)
        {
            return await _context.Set<ExpensePromotion>()
               .Include(c => c.Employee)
               .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<ExpenseType>> GetExpenseTypes()
        {
            return await _context.Set<ExpenseType>()
               .Include(c => c.ExpenseClaim)
               .ToListAsync();
        }
        public async Task<List<ExpensePromotion>> GetExpensePromotions(int id)
        {
            return await _context.Set<ExpensePromotion>()
               .Include(c => c.Employee)
               .Include(t=>t.ToPromotion)
               .Include(f=>f.FromPromotion).Where(c=>c.CompanyId == id)
               .ToListAsync();
        }

        public async Task UpdateExpenseType(ExpenseType model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task UpdateExpensePromotion(ExpensePromotion model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveExpenseType(int id)
        {
            var data = await _context.Set<ExpenseType>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<ExpenseType>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveExpensePromotion(int id)
        {
            var data = await _context.Set<ExpensePromotion>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<ExpensePromotion>().Remove(data);
            await _context.SaveChangesAsync();
        }
    }
}
