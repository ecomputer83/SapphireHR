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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MailTemplate>().HasData(new MailTemplate { Id = 1, TemplateCode = "EMPLOYEE_REGISTRATION", TemplateName = "Employee Registration Account",
                TemplateSubject = "[company] Employee Registration Account", TemplateBody = "<p><img src=\"data:image/png;base64,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\" alt = \"\" width = \"63\" height = \"63\" /></p>"+
"<p><em> Hi[name],</em></p>"+
"<p><em><strong>[company] </strong> have added you to their company,"+
"                You have been assigned as <strong>[designation] </strong> of this company.</em></p>" +
"<p><em> Check your account information below </em></p>"+
"<p><em><strong> Account Link </strong>: [header] </em></p>"+
"<p><em><strong> Employee Email </strong>: [email] </em></p>"+
"<p><strong><em> Employee Password:[password]</em></strong></p>"+
"      <p><em> You are free to change your password at any time.</em></p>"+
"           <p> &nbsp;</p>"+
"             <p><em> Take care! </em><br /><em>[name] </em></p>"+
"                   <p> &nbsp;</p>"+
"                      <p> &nbsp;</p> ", CopySender = 0,
            IsBodyHtml = 1, IsSystem = false, Priority = "High", Status = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM"});

            builder.Entity<MailTemplate>().HasData(new MailTemplate
            {
                Id = 2,
                TemplateCode = "WELCOME_MSG",
                TemplateName = "Welcome Message",
                TemplateSubject = "[org] Registration Account",
                TemplateBody = "<p><img src=\"data:image/png;base64,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\" alt = \"\" width = \"63\" height = \"63\" /></p>" +
"<p><em> Hi[name],</em></p>" +
"<p><em>Thank your for registering with Us. We&rsquo;re confident that Sapphire HRM will help you in Human Resource Managent of your organization.</em></p>" +
"<p><em><strong>[org]</strong> has been registered with us.</em></p>" +
"<p><em> Check your account information below </em></p>" +
"<p><em><strong> Account Link </strong>: [header] </em></p>" +
"<p><em><strong> Admin Email </strong>: [email] </em></p>" +
"      <p><em> You are free to change your password at any time.</em></p>" +
"           <p> &nbsp;</p>" +
"             <p><em> Take care! </em><br /><em>[name] </em></p>" +
"                   <p> &nbsp;</p>" +
"                      <p> &nbsp;</p> ",
                CopySender = 0,
                IsBodyHtml = 1,
                IsSystem = false,
                Priority = "High",
                Status = 1,
                CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886),
                CreatedBy = "SYSTEM"
            });

            builder.Entity<MailTemplate>().HasData(new MailTemplate
            {
                Id = 3,
                TemplateCode = "HR_REGISTRATION",
                TemplateName = "HR Registration Account",
                TemplateSubject = "[company] HR Registration Account",
                TemplateBody = "<p><img src=\"data:image/png;base64,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\" alt = \"\" width = \"63\" height = \"63\" /></p>" +
"<p><em> Hi[name],</em></p>" +
"<p><em><strong>[company]</strong> has been created, You have been assigned as <strong>HR</strong> of this company" +
"</em></p>" +
"<p><em> Check your account information below </em></p>" +
"<p><em><strong> Account Link </strong>: [header] </em></p>" +
"<p><em><strong> HR Email </strong>: [email] </em></p>" +
"<p><strong><em> HR Password:[password]</em></strong></p>" +
"      <p><em> You are free to change your password at any time.</em></p>" +
"           <p> &nbsp;</p>" +
"             <p><em> Take care! </em><br /><em>[name] </em></p>" +
"                   <p> &nbsp;</p>" +
"                      <p> &nbsp;</p> ",
                CopySender = 0,
                IsBodyHtml = 1,
                IsSystem = false,
                Priority = "High",
                Status = 1,
                CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886),
                CreatedBy = "SYSTEM"
            });
            builder = SeedLookup(builder);


            base.OnModelCreating(builder);
        }

        private ModelBuilder SeedLookup(ModelBuilder builder)
        {
            builder.Entity<Lookup>().HasData(new Lookup { Id = 1, LookupType = "BANKS", LookupValue = "044", LookupDescription = "Access Bank Nigeria Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 2, LookupType = "BANKS", LookupValue = "063", LookupDescription = "Diamond Bank Plc", LookupSort = 2, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 3, LookupType = "BANKS", LookupValue = "050", LookupDescription = "Ecobank Nigeria", LookupSort = 3, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 4, LookupType = "BANKS", LookupValue = "084", LookupDescription = "Enterprise Bank Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 5, LookupType = "BANKS", LookupValue = "070", LookupDescription = "Fidelity Bank Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 6, LookupType = "BANKS", LookupValue = "011", LookupDescription = "First Bank of Nigeria Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 7, LookupType = "BANKS", LookupValue = "214", LookupDescription = "First City Monument Bank", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 8, LookupType = "BANKS", LookupValue = "058", LookupDescription = "Guaranty Trust Bank Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 9, LookupType = "BANKS", LookupValue = "030", LookupDescription = "Heritage Banking Company Ltd", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 10, LookupType = "BANKS", LookupValue = "301", LookupDescription = "Jaiz Bank", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 11, LookupType = "BANKS", LookupValue = "082", LookupDescription = "Keystone Bank Ltd", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 12, LookupType = "BANKS", LookupValue = "014", LookupDescription = "Mainstreet Bank Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 13, LookupType = "BANKS", LookupValue = "039", LookupDescription = "Stanbic IBTC Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 14, LookupType = "BANKS", LookupValue = "232", LookupDescription = "Sterling Bank Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 15, LookupType = "BANKS", LookupValue = "032", LookupDescription = "Union Bank Nigeria Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 16, LookupType = "BANKS", LookupValue = "033", LookupDescription = "United Bank for Africa Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 17, LookupType = "BANKS", LookupValue = "215", LookupDescription = "Unity Bank Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 18, LookupType = "BANKS", LookupValue = "035", LookupDescription = "WEMA Bank Plc", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            builder.Entity<Lookup>().HasData(new Lookup { Id = 19, LookupType = "BANKS", LookupValue = "057", LookupDescription = "Zenith Bank International", LookupSort = 1, CreatedAt = new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886), CreatedBy = "SYSTEM" });
            return builder;
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
        public DbSet<EmployeeTax> EmployeeTaxes { get; set; }
        public DbSet<EmployeeTimetable> EmployeeTimetables { get; set; }
        public DbSet<EmployeeTermination> EmployeeTerminations { get; set; }
        public DbSet<EmployeeTransfer> EmployeeTransfers { get; set; }
        public DbSet<EmployeeManager> EmployeeManagers { get; set; }
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
        public DbSet<DisciplinaryMeasures> DisciplinaryMeasures { get; set; }
        public DbSet<SkillGrade> SkillGrades { get; set; }
        public DbSet<TerminationType> TerminationTypes { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Vacancysettings> Vacancysettings { get; set; }
        public DbSet<Lookup> Lookups { get; set; }
        public DbSet<MailTemplate> MailTemplate { get; set; }
        public DbSet<EmployeeRoleComment> EmployeeRoleComments { get; set; }
        public DbSet<EmployeeResponsibilityComment> EmployeeResponsibilityComments { get; set; }
        public DbSet<EmployeeHODImprovementComment> EmployeeHODImprovementComments { get; set; }
        public DbSet<EmployeeROImprovementComment> EmployeeROImprovementComments { get; set; }
        public DbSet<EmployeeProfGoalPlan> EmployeeProfGoalPlans { get; set; }
        public DbSet<EmployeeProfGoalAchieved> EmployeeProfGoalAchieveds { get; set; }
        public DbSet<EmployeePersonalGoals> EmployeePersonalGoals { get; set; }
        public DbSet<EmployeeInitiativeAchievement> EmployeeInitiativeAchievements { get; set; }
        public DbSet<EmployeeObservation> EmployeeObservations { get; set; }
        public DbSet<EmployeeTrainingRequirement> EmployeeTrainingRequirements { get; set; }
        public DbSet<EmployeePersonalExcellence> EmployeePersonalExcellences { get; set; }
        public DbSet<EmployeeProffesionalExcellence> EmployeeProffesionalExcellences { get; set; }
        public DbSet<ProffesionalExcellenceSettings> ProffesionalExcellenceSettings { get; set; }
        public DbSet<PersonalExcellenceSettings> PersonalExcellenceSettings { get; set; }
        public DbSet<EmployeePerfomanceAppraisal> EmployeePerfomanceAppraisals { get; set; }
        public DbSet<OrganizationSettings> OrganizationSettings { get; set; }
        public DbSet<SalaryBatchPayment> SalaryBatchPayments { get; set; }
        public DbSet<SalaryPayment> SalaryPayments { get; set; }
        public DbSet<PensionBatchPayment> PensionBatchPayments { get; set; }
        public DbSet<PensionPayment> PensionPayments { get; set; }
        public DbSet<TaxBatchPayment> TaxBatchPayments { get; set; }
        public DbSet<TaxPayment> TaxPayments { get; set; }
        public DbSet<CompanyAccount> CompanyAccounts { get; set; }
        public DbSet<Query> Queries { get; set; }



        public virtual DbSet<MailMessage> MailMessage { get; set; }
        public virtual DbSet<MailMessageAddress> MailMessageAddress { get; set; }
        public virtual DbSet<MailMessageAttachment> MailMessageAttachment { get; set; }
        public virtual DbSet<MailMessageQueue> MailMessageQueue { get; set; }
        
    }
}

