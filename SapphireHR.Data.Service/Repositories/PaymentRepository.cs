using SapphireHR.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class PaymentRepository : GenericRepository<Database.EntityModels.SalaryBatchPayment, ApplicationDbContext>
    {
        public PaymentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task AddSalaries(Database.EntityModels.SalaryPayment[] models)
        {
            this._context.Set<Database.EntityModels.SalaryPayment>().AddRange(models);
            await _context.SaveChangesAsync();
        }

        public async Task AddPensions(Database.EntityModels.PensionPayment[] models)
        {
            this._context.Set<Database.EntityModels.PensionPayment>().AddRange(models);
            await _context.SaveChangesAsync();
        }

        public async Task AddTaxes(Database.EntityModels.TaxPayment[] models)
        {
            this._context.Set<Database.EntityModels.TaxPayment>().AddRange(models);
            await _context.SaveChangesAsync();
        }

        public async Task<Database.EntityModels.PensionBatchPayment> AddBatchPension(Database.EntityModels.PensionBatchPayment model)
        {
            this._context.Set<Database.EntityModels.PensionBatchPayment>().Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Database.EntityModels.TaxBatchPayment> AddBatchTax(Database.EntityModels.TaxBatchPayment model)
        {
            this._context.Set<Database.EntityModels.TaxBatchPayment>().Add(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
