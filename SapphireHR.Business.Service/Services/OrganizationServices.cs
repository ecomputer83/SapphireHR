using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Business.DocumentManager.Documents;
using SapphireHR.Data.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.Service.Services
{
    public class OrganizationServices : IOrganizationService
    {
        OrganizationRepository _orgRepository;
        FileManager _fileManager;
        readonly IMapper _mapper;
        public OrganizationServices(OrganizationRepository orgRepository, FileManager fileManager, IMapper mapper)
        {
            this._orgRepository = orgRepository;
            _fileManager = fileManager;
            this._mapper = mapper;
        }
        public async Task<OrganizationModel> GetOrganizationByHostHeader(string hostname)
        {
            var org = await _orgRepository.GetOrganizationByHostHeader(hostname);
            return _mapper.Map<OrganizationModel>(org);
        }
        public async Task AddLeaveType(LeaveTypeModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.LeaveType>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await this._orgRepository.AddLeaveType(datamodel);
        }

        public async Task AddOrganization(OrganizationModel model)
        {
            ///DocumentService for Creating Org folder
            var orgUrl = await _fileManager.CreateOrgDirectory(model.Name.Trim().ToLower().Replace(" ", ""));
            var datamodel = _mapper.Map<Database.EntityModels.OrganizationInfo>(model);
            datamodel.Directory = orgUrl;
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await this._orgRepository.Add(datamodel);
        }

        public async Task AddOrganizationHeader(OrganizationHeaderModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.OrganizationHeader>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await this._orgRepository.AddOrgHeader(datamodel);
        }

        public async Task DeleteOrganization(int Id)
        {
            await this._orgRepository.Delete(Id);
        }

        public async Task RemoveLeaveType(int id)
        {
            await this._orgRepository.RemoveLeaveType(id);
        }

        public async Task UpdateOrganization(OrganizationModel model, int Id)
        {
            var org = await this._orgRepository.Get(Id);
            org.Name = model.Name;
            org.Phone = model.Phone;
            org.Email = model.Email;
            org.ContactPerson = model.ContactPerson;
            org.Address = model.Address;
            org.UpdatedAt = DateTime.Now;
            await this._orgRepository.Update(org);
        }

        public async Task AddRank(RankModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.Rank>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await this._orgRepository.AddRank(datamodel);
        }

        public async Task<List<RankModel>> GetRanks(int orgId)
        {
            var ranks = await this._orgRepository.ReadRanks(orgId);
            return _mapper.Map<List<RankModel>>(ranks);
        }

        public async Task UpdateRank(RankModel model, int Id)
        {
            var rank = await this._orgRepository.ReadRank(Id);
            rank.RankName = model.RankName;
            await this._orgRepository.UpdateRank(rank);
        }

        public async Task RemoveRank(int Id)
        {
            await this._orgRepository.RemoveRank(Id);
        }

        public async Task AddRankPermission(RankPermissionModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.RankPermission>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            await this._orgRepository.AddRankPermission(datamodel);
        }

        public async Task<RankPermissionModel> GetRankPermission(int orgId)
        {
            var ranks = await this._orgRepository.ReadRankPermission(orgId);
            return _mapper.Map<RankPermissionModel>(ranks);
        }

        public async Task UpdateRankPermission(RankPermissionModel model, int Id)
        {
            var permission = await this._orgRepository.ReadRankPermission(Id);
            var updatedPermission = _mapper.Map<Database.EntityModels.RankPermission>(model);
            updatedPermission.Id = Id;
            updatedPermission.CreatedAt = permission.CreatedAt;
            updatedPermission.CreatedBy = permission.CreatedBy;
            updatedPermission.UpdatedAt = DateTime.Now;
            updatedPermission.UpdatedBy = "SYSTEM";
            await this._orgRepository.UpdateRankPermission(updatedPermission);
        }

        public async Task RemoveRankPermission(int Id)
        {
            await this._orgRepository.RemoveRankPermission(Id);
        }
    }
}
