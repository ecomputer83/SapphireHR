using AutoMapper;
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
            CreateMap<OrganizationModel, OrganizationInfo>().ReverseMap();
            CreateMap<LeaveTypeModel, LeaveType>().ReverseMap();
            CreateMap<OrganizationHeaderModel, OrganizationHeader>().ReverseMap();
            CreateMap<RankModel, Rank>().ReverseMap();
            CreateMap<RankPermissionModel, RankPermission>().ReverseMap();
            CreateMap<CompanyModel, CompanyInfo>().ReverseMap();
            CreateMap<LeaveSettingModel, LeaveSetting>().ReverseMap();
            CreateMap<EmployeeBankModel, EmployeeBank>().ReverseMap();
            CreateMap<JobSkillLevelModel, JobSkillLevel>().ReverseMap();
            CreateMap<JobProfileModel, JobProfile>().ReverseMap();
            CreateMap<VacancyModel, Vacancy>().ReverseMap();
            CreateMap<JobProfessionModel, JobProfession>().ReverseMap();
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
            CreateMap<EmployeeStatutoryModel, EmployeeStatutory>().ReverseMap();
            CreateMap<EmployeeTimetableModel, EmployeeTimetable>().ReverseMap();
            CreateMap<EmployeeTransferModel, EmployeeTransfer>().ReverseMap();
            CreateMap<EmployeeModel, Employee>().ReverseMap();
            CreateMap<UserModel, User>().ReverseMap();
            CreateMap<VacancyModel, Vacancy>().ReverseMap();
            CreateMap<ApplicationNegotiationModel, ApplicationNegotiation>().ReverseMap();
            CreateMap<ApplicationSkillModel, ApplicationSkills>().ReverseMap();
            CreateMap<ApplicationInterviewModel, ApplicationInterview>().ReverseMap();
            CreateMap<ApplicationFaceToViewModel, ApplicationFaceToView>().ReverseMap();
            CreateMap<ApplicationScoreModel, ApplicationScore>().ReverseMap();
            CreateMap<DesignationModel, Designation>().ReverseMap();
            CreateMap<DepartmentModel, Department>().ReverseMap();
            CreateMap<UserViewModel, UserModel>();
        }
    }
}
