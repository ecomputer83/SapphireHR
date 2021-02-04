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
        public DbSet<CompanyRank> CompanyRanks { get; set; }
        public DbSet<EmployeeBank> EmployeeBanks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OrganizationHeader> OrganizationHeaders { get; set; }
        public DbSet<OrganizationInfo> OrganizationInfos { get; set; }
        public DbSet<CompanyLeavePolicy> CompanyLeavePolicies { get; set; }
        public DbSet<EmployeeBank> EmployeeBankss { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DbSet<EmployeeEmergency> EmployeeEmergencies { get; set; }
        public DbSet<EmployeeExperience> EmployeeExperiences { get; set; }
        public DbSet<EmployeeFamily> EmployeeFamilies { get; set; }
        public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }
        public DbSet<EmployeePension> EmployeePensions { get; set; }
        public DbSet<EmployeeStatutory> EmployeeStatutories { get; set; }
        public DbSet<EmployeeTimetable> EmployeeTimetables { get; set; }
        public DbSet<EmployeeTransfer> EmployeeTransfers { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<LeavePolicy> LeavePolicies { get; set; }
        public DbSet<LeaveSetting> LeaveSettings { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Onboarding> Onboardings { get; set; }
        public DbSet<RankPermission> RankPermissions { get; set; }

    }
}
