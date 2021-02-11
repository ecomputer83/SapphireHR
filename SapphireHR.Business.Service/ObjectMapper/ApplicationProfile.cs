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
            CreateMap<SkillTypeModel, SkillType>().ReverseMap();
            CreateMap<SkillGradeModel, SkillGrade>().ReverseMap();
        }
    }
}
