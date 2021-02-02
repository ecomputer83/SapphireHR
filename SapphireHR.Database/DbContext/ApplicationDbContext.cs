using Microsoft.EntityFrameworkCore;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<CompanyEmployee> CompanyEmployees { get; set; }
        public DbSet<CompanyRank> companyRanks { get; set; }
        public DbSet<EmployeeBank> EmployeeBanks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OrganizationHeader> OrganizationHeaders { get; set; }
        public DbSet<OrganizationInfo> OrganizationInfos { get; set; }
    }
}
