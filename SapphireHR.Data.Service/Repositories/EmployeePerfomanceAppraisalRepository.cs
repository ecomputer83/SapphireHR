﻿using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class EmployeePerfomanceAppraisalRepository : GenericRepository<EmployeePerfomanceAppraisal, ApplicationDbContext>
    {
        public EmployeePerfomanceAppraisalRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<EmployeePerfomanceAppraisal>> GetAllEmployeePerfomanceAppraisal(int id)
        {
            var companyIdParam = new Microsoft.Data.SqlClient.SqlParameter("@companyId", id);
            return await _context.EmployeePerfomanceAppraisals.FromSqlRaw(@"Select s.* from dbo.CompanyEmployees c inner join dbo.EmployeePerfomanceAppraisals s on c.EmployeeId = s.EmployeeId where c.CompanyId = @companyId", companyIdParam).Include(e => e.Employee).Include(d =>d.DesignationPerformance).ToListAsync();


        }
    }
}