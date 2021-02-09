using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Data.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Service.ObjectMapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<CompanyModel, CompanyInfo>().ReverseMap();
            CreateMap<LeaveSettingModel, LeaveSetting>().ReverseMap();
            CreateMap<LeaveTypeModel, LeaveType>().ReverseMap();
            CreateMap<OrganizationModel, OrganizationInfo>().ReverseMap();
            CreateMap<OrganizationHeaderModel, OrganizationHeader>().ReverseMap();
            CreateMap<RankModel, Rank>().ReverseMap();
            CreateMap<RankPermissionModel, RankPermission>().ReverseMap();
        }
    }
}
