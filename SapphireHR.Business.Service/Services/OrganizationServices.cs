using AutoMapper;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Business.DocumentManager.Documents;
using SapphireHR.Data.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SapphireHR.Business.Integrations;

namespace SapphireHR.Business.Service.Services
{
    public class OrganizationServices : IOrganizationService
    {
        OrganizationRepository _orgRepository;
        FileManager _fileManager;
        SysAdminClientService _sysAdminClientService;
        readonly IMapper _mapper;
        private readonly IConfiguration _config;
        public OrganizationServices(OrganizationRepository orgRepository, FileManager fileManager, IMapper mapper, IConfiguration config, SysAdminClientService sysAdminClientService)
        {
            this._orgRepository = orgRepository;
            _fileManager = fileManager;
            this._mapper = mapper;
            this._config = config;
            _sysAdminClientService = sysAdminClientService;
        }
        public async Task<OrganizationModel> GetOrganizationAsync(int orgId)
        {
            var org = await _orgRepository.Get(orgId);

            org.OrganizationHeader = await _orgRepository.GetOrgHeader(orgId);
            return _mapper.Map<OrganizationModel>(org);
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

        public async Task<int> AddOrganization(OrganizationModel model)
        {
            var exist = await this._orgRepository.GetOrganizationByName(model.Name);

            if (exist != null)
                throw new Exception("Organization Name already exists.");
            string orgUrl = null;
            ///DocumentService for Creating Org folder
            var storeToBlob = bool.Parse(_config.GetSection("FileSystem")["StoreToBlob"]);
            string directory = null;
            if (storeToBlob)
            {
                orgUrl = await _fileManager.CreateOrgDirectory(model.Name.Trim().ToLower().Replace(" ", ""));
            }
            var datamodel = _mapper.Map<Database.EntityModels.OrganizationInfo>(model);
            if(storeToBlob)
            datamodel.Directory = orgUrl;
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            datamodel = await this._orgRepository.Add(datamodel);

            var hostname = datamodel.Name.Replace(" ", "").ToLower();
            var domain = _config.GetValue<string>("MyDomain");
            var domainPort = _config.GetValue<string>("MyDomainPort");
            var websiteName = _config.GetValue<string>("MyClient");
            try
            {
                await _sysAdminClientService.PostHostHeader(new Abstractions.SysAdminRequest { hostHeader = $":{domainPort}:{hostname}.{domain}", websiteName = websiteName });
            }
            catch(Exception ex)
            {

            }
            var headermodel = new Database.EntityModels.OrganizationHeader
            {
                OrganizationId = datamodel.Id,
                HostName = $"{hostname}.{domain}",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = "SYSTEM",
                UpdatedBy = "SYSTEM"
            };

            await this._orgRepository.AddOrgHeader(headermodel);

            //
            return datamodel.Id;
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

        public async Task<int> AddRank(RankModel model)
        {
            var datamodel = _mapper.Map<Database.EntityModels.Rank>(model);
            datamodel.CreatedAt = DateTime.Now;
            datamodel.UpdatedAt = DateTime.Now;
            datamodel.CreatedBy = "SYSTEM";
            datamodel.UpdatedBy = "SYSTEM";
            return await this._orgRepository.AddRank(datamodel);
        }

        public async Task<List<RankModel>> GetRanks(int orgId)
        {
            var ranks = await this._orgRepository.ReadRanks(orgId);
            return _mapper.Map<List<RankModel>>(ranks);
        }
        public async Task<RankModel> GetRank(int Id)
        {
            var ranks = await this._orgRepository.ReadRank(Id);
            return _mapper.Map<RankModel>(ranks);
        }

        public async Task<RankModel> GetRank(int orgId, string name)
        {
            var ranks = await this._orgRepository.ReadRank(orgId, name);
            return _mapper.Map<RankModel>(ranks);
        }

        public async Task<List<LeaveTypeModel>> GetLeaveTypes(int orgId)
        {
            var leavetypes = await this._orgRepository.ReadLeaveTypes(orgId);
            return _mapper.Map<List<LeaveTypeModel>>(leavetypes);
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
            if (permission != null)
            {
                var updatedPermission = _mapper.Map<Database.EntityModels.RankPermission>(model);
                updatedPermission.Id = Id;
                updatedPermission.CreatedAt = permission.CreatedAt;
                updatedPermission.CreatedBy = permission.CreatedBy;
                updatedPermission.UpdatedAt = DateTime.Now;
                updatedPermission.UpdatedBy = "SYSTEM";
                await this._orgRepository.UpdateRankPermission(updatedPermission);
            }
        }

        public async Task RemoveRankPermission(int Id)
        {
            await this._orgRepository.RemoveRankPermission(Id);
        }
    }
}
