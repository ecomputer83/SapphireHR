using AutoMapper;
using SapphireHR.Business.Abstractions;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Service.ObjectMapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<ExpenseClaimModel, ExpenseClaim>().ReverseMap();
            CreateMap<ExpenseTypeModel, ExpenseType>().ReverseMap();
            CreateMap<ExpensePromotionModel, ExpensePromotion>().ReverseMap();
            CreateMap<DesignationPerformanceModel, DesignationPerformance>().ReverseMap();
            CreateMap<LeaveTypeModel, LeaveType>().ReverseMap();
            CreateMap<OrganizationModel, OrganizationInfo>().ReverseMap();
            CreateMap<LeaveTypeModel, LeaveType>().ReverseMap();
            CreateMap<OrganizationHeaderModel, OrganizationHeader>().ReverseMap();
            CreateMap<RankModel, Rank>().ReverseMap();
            CreateMap<RankPermissionModel, RankPermission>().ReverseMap();
            CreateMap<CompanyModel, CompanyInfo>().ReverseMap();
            CreateMap<CompanyAccountModel, CompanyAccount>().ReverseMap();
            CreateMap<LeaveSettingModel, LeaveSetting>().ReverseMap();
            CreateMap<LeavePolicyModel, LeavePolicy>().ReverseMap();
            CreateMap<CompanyLeavePolicyModel, CompanyLeavePolicy>().ReverseMap();
            CreateMap<EmployeeBankModel, EmployeeBank>().ReverseMap();
            CreateMap<JobSkillLevelModel, JobSkillLevel>().ReverseMap();
            CreateMap<JobProfileModel, JobProfile>().ReverseMap();
            CreateMap<VacancyModel, Vacancy>().ReverseMap();
            CreateMap<JobProfessionModel, JobProfession>().ReverseMap();
            CreateMap<JobRequisitionModel, JobRequisition>().ReverseMap();
            CreateMap<EmployeeTerminationModel, EmployeeTermination>().ReverseMap();
            CreateMap<EmployeeResignationModel, EmployeeResignation>().ReverseMap();
            CreateMap<TerminationTypeModel, TerminationType>().ReverseMap();
            CreateMap<SkillModel, Skill>().ReverseMap();
            CreateMap<SkillTypeModel, SkillType>().ReverseMap();
            CreateMap<SkillGradeModel, SkillGrade>().ReverseMap();
            CreateMap<CompanyEmployeeModel, CompanyEmployee>().ReverseMap();
            CreateMap<EmployeeEducationModel, EmployeeEducation>().ReverseMap();
            CreateMap<EmployeeEmergencyModel, EmployeeEmergency>().ReverseMap();
            CreateMap<EmployeeExperienceModel, EmployeeExperience>().ReverseMap();
            CreateMap<EmployeeFamilyModel, EmployeeFamily>().ReverseMap();
            CreateMap<EmployeeLeaveModel, EmployeeLeave>().ReverseMap();
            CreateMap<EmployeePensionModel, EmployeePension>().ReverseMap();
            CreateMap<EmployeeTaxModel, EmployeeTax>().ReverseMap();
            CreateMap<EmployeeStatutoryModel, EmployeeStatutory>().ReverseMap();
            CreateMap<EmployeeTimetableModel, EmployeeTimetable>().ReverseMap();
            CreateMap<EmployeeTransferModel, EmployeeTransfer>().ReverseMap();
            CreateMap<EmployeeSalaryModel, EmployeeSalary>().ReverseMap();
            CreateMap<EmployeeModel, Employee>().ReverseMap();
            CreateMap<EmployeeManagerModel, EmployeeManager>().ReverseMap();
            CreateMap<UserModel, User>().ReverseMap();
            CreateMap<VacancyModel, Vacancy>().ReverseMap();
            CreateMap<VacancysettingsModel, Vacancysettings>().ReverseMap();
            CreateMap<ExitInterviewModel, ExitInterview>().ReverseMap();
            CreateMap<VacancySummaryModel, VacancySummary>().ReverseMap();
            CreateMap<ApplicationNegotiationModel, ApplicationNegotiation>().ReverseMap();
            CreateMap<ApplicationSkillModel, ApplicationSkills>().ReverseMap();
            CreateMap<ApplicationInterviewModel, ApplicationInterview>().ReverseMap();
            CreateMap<ApplicationFaceToViewModel, ApplicationFaceToView>().ReverseMap();
            CreateMap<ApplicationScoreModel, ApplicationScore>().ReverseMap();
            CreateMap<ApplicationModel, Application>().ReverseMap();
            CreateMap<DesignationModel, Designation>().ReverseMap();
            CreateMap<DepartmentModel, Department>().ReverseMap();
            CreateMap<LookupModel, Lookup>().ReverseMap();
            CreateMap<ApplicantModel, Applicant>().ReverseMap();
            CreateMap<UserViewModel, UserModel>();
            CreateMap<EmployeeResignationModel, EmployeeResignation>().ReverseMap();
            CreateMap<DisciplinaryMeasuresModel, DisciplinaryMeasures>().ReverseMap();
            CreateMap<QueryModel, Query>().ReverseMap();
            CreateMap<RemitaSalaryRequest, SalaryBatchPayment>().ReverseMap();
            CreateMap<MonthlyAttendanceReview, MonthlyAttendanceReviewModel>().ReverseMap();
            CreateMap<EmployeePerfomanceAppraisal, EmployeePerfomanceAppraisalModel>().ReverseMap();
            CreateMap<SalaryTransaction, SalaryPayment>()
                .ForMember(x => x.SalaryId, opt => opt.ConvertUsing(new RemoveSalaryIdFromTrans(), y => y.TransactionRef));
            CreateMap<RemitaPensionRequest, PensionBatchPayment>().ReverseMap();
            CreateMap<PensionTransaction, PensionPayment>()
                .ForMember(x => x.SalaryId, opt => opt.ConvertUsing(new RemoveSalaryIdFromTrans(), y => y.TransactionRef));
            CreateMap<RemitaTaxRequest, TaxBatchPayment>().ReverseMap();
            CreateMap<TaxTransaction, TaxPayment>()
                .ForMember(x => x.SalaryId, opt => opt.ConvertUsing(new RemoveSalaryIdFromTrans(), y => y.TransactionRef));
            CreateMap<Policy, PolicyModel>()
                .ForMember(x => x.Department, opt => opt.MapFrom(c=>c.DepartmentPolicy.Department))
                .ForMember(x => x.DepartmentId, opt => opt.MapFrom(c => c.DepartmentPolicy.DepartmentId)).ReverseMap();
        }

    }

    public class RemoveSalaryIdFromTrans : IValueConverter<string, int>
    {
        public int Convert(string sourceMember, ResolutionContext context)
        {
            var ret = sourceMember;
            string i = ret.Split('E')[0];
            return int.Parse(i);
        }
    }
}
