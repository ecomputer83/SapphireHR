using Microsoft.EntityFrameworkCore;
using SapphireHR.Data.Service.Repositories;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service
{
    public class MailTemplateRepository : GenericRepository<MailTemplate, ApplicationDbContext>
    {
        private ApplicationDbContext _context;
        public MailTemplateRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<MailTemplate> GetByCode (string Code)
        {
            return await _context.MailTemplate.FirstOrDefaultAsync(c => c.TemplateCode == Code);
        }
    }
}
