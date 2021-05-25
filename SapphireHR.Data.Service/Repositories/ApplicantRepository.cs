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
    public class ApplicantRepository : GenericRepository<Applicant, ApplicationDbContext>
    {
        public ApplicantRepository(ApplicationDbContext context) : base(context)
        {
        }
        public Task<Applicant> GetNoTrackingApplicant(int id)
        {
            return _context.Applicants.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }
        public Task<List<Applicant>> GetApplicants(int orgId)
        {
            return _context.Set<Applicant>().Where(c => c.CompanyId == orgId).ToListAsync();
        }
        public Task<Applicant> GetApplicantByEmail(string email)
        {
            return _context.Set<Applicant>().FirstOrDefaultAsync(c => c.Email == email);
        }
    }
}
