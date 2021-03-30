using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationFaceToView> ApplicationFaceToViews { get; set; }
        public DbSet<ApplicationInterview> ApplicationInterviews { get; set; }
        public DbSet<ApplicationNegotiation> ApplicationNegotiations { get; set; }
        public DbSet<ApplicationScore> ApplicationScores { get; set; }
        public DbSet<ApplicationSkills> ApplicationSkills { get; set; }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<CompanyEmployee> CompanyEmployees { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<DesignationPerformance> DesignationPerformances { get; set; }
        public DbSet<EmployeeBank> EmployeeBanks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OrganizationHeader> OrganizationHeaders { get; set; }
        public DbSet<OrganizationInfo> OrganizationInfos { get; set; }
        public DbSet<CompanyLeavePolicy> CompanyLeavePolicies { get; set; }
        public DbSet<EmployeeBank> EmployeeBankss { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
        public DbSet<EmployeeStatutory> EmployeeStatutories { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DbSet<EmployeeEmergency> EmployeeEmergencies { get; set; }
        public DbSet<EmployeeExperience> EmployeeExperiences { get; set; }
        public DbSet<EmployeeFamily> EmployeeFamilies { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<ExpenseClaim> ExpenseClaims { get; set; }
        public DbSet<ExpensePromotion> EmployeePromotions { get; set; }
        public DbSet<EmployeeTravel> EmployeeTravels { get; set; }
        public DbSet<EmployeeResignation> EmployeeResignations { get; set; }
        public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }
        public DbSet<EmployeePension> EmployeePensions { get; set; }
        public DbSet<EmployeeTimetable> EmployeeTimetables { get; set; }
        public DbSet<EmployeeTermination> EmployeeTerminations { get; set; }
        public DbSet<EmployeeTransfer> EmployeeTransfers { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobProfession> JobProfessions { get; set; }
        public DbSet<JobProfile> JobProfiles { get; set; }
        public DbSet<JobRequisition> JobRequisitions { get; set; }
        public DbSet<JobSkillLevel> JobSkillLevels { get; set; }
        public DbSet<LeavePolicy> LeavePolicies { get; set; }
        public DbSet<LeaveSetting> LeaveSettings { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Onboarding> Onboardings { get; set; }
        public DbSet<RankPermission> RankPermissions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillType> SkillTypes { get; set; }

        public DbSet<SkillGrade> SkillGrades { get; set; }
        public DbSet<TerminationType> TerminationTypes { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Lookup> Lookups { get; set; }
        public virtual DbSet<MailMessage> MailMessage { get; set; }
        public virtual DbSet<MailMessageAddress> MailMessageAddress { get; set; }
        public virtual DbSet<MailMessageAttachment> MailMessageAttachment { get; set; }
        public virtual DbSet<MailMessageQueue> MailMessageQueue { get; set; }
        public virtual DbSet<MailTemplate> MailTemplate { get; set; }
    }
}

