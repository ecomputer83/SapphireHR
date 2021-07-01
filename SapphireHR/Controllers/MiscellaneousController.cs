using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SapphireHR.Business.Abstractions.Models;
using SapphireHR.Business.Abstractions.Service;
using SapphireHR.Business.DocumentManager.Documents;
using SapphireHR.Business.DocumentManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SapphireHR.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MiscellaneousController : BaseApiController
    {
        private readonly ILogger _logger;
        IMiscellaneousService _miscellaneousService;
        IOrganizationService _organizationService;
        FileManager _fileManager;
        private readonly IConfiguration _config;
        public MiscellaneousController(ILogger<MiscellaneousController> logger, FileManager fileManager, IMiscellaneousService miscellaneousService, IOrganizationService organizationService, IConfiguration config) : base(organizationService)
        {
            _logger = logger;
            _fileManager = fileManager;
            _miscellaneousService = miscellaneousService;
            _organizationService = organizationService;
            _config = config;
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getApplicantById")]
        public async Task<IActionResult> GetApplicantById(int id)
        {
            try
            {
                var res = await _miscellaneousService.GetApplicant(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getAllApplicant")]
        public async Task<IActionResult> GetApplicants(int Id)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _miscellaneousService.GetApplicants(Id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getpolicies")]
        public async Task<IActionResult> GetPolicies()
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _miscellaneousService.GetPolicies(org.Id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }


        [Authorize]
        [HttpGet]
        [Route("getDepartmentById")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            try
            {
                var res = await _miscellaneousService.GetDepartment(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet]
        [Route("getDepartments")]
        public async Task<IActionResult> GetDepartments()
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _miscellaneousService.GetDepartments(org.Id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpGet]
        [Route("getTerminationTypes")]
        public async Task<IActionResult> GetTerminationTypes()
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _miscellaneousService.GetTerminationTypes(org.Id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet]
        [Route("getDesignations")]
        public async Task<IActionResult> GetDesignations()
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _miscellaneousService.GetDesignations(org.Id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet]
        [Route("getLookup")]
        public async Task<IActionResult> GetLookup(string type)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                var res = await _miscellaneousService.GetLookups(type);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpGet]
        [Route("getDesignationById")]
        public async Task<IActionResult> GetDesignationById(int id)
        {
            try
            {
                var res = await _miscellaneousService.GetDesignation(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [HttpPost]
        [Route("createApplicant/{companyId}")]
        public async Task<IActionResult> PostApplicant([FromBody] ApplicantModel model, int companyId)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                //model.OrganizationId = org.Id;
                var Id = await _miscellaneousService.AddApplicant(model);

                // TODO Upload CV to documentManager
                var blob = new BlobStore
                {
                    FileName = model.Uploadfile.FileName,
                    ContentType = model.Uploadfile.ContentType,
                    FileLength = model.Uploadfile.Length,
                    FileStream = model.Uploadfile.OpenReadStream()
                };

                await _fileManager.UploadFileToApplicantdFolder(blob, org.Name.Trim().ToLower().Replace(" ", ""), companyId.ToString(), Id.ToString());
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        [Route("createDepartment")]
        public async Task<IActionResult> PostDepartment([FromBody] DepartmentModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                model.OrganizationId = org.Id;
                await _miscellaneousService.AddDepartment(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        [Route("createPolicy/{companyId}")]
        public async Task<IActionResult> PostPolicy([FromForm] PolicyModel model, int companyId)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                string Document = null;
                var storeToBlob = bool.Parse(_config.GetSection("FileSystem")["StoreToBlob"]);
                if (storeToBlob && model.Uploadfile != null)
                {
                    // TODO Upload CV to documentManager
                    var blob = new BlobStore
                    {
                        FileName = model.Uploadfile.FileName,
                        ContentType = model.Uploadfile.ContentType,
                        FileLength = model.Uploadfile.Length,
                        FileStream = model.Uploadfile.OpenReadStream()
                    };

                    Document = await _fileManager.UploadFileToDepartmentFolder(blob, org.Name.Trim().ToLower().Replace(" ", ""), companyId.ToString(), model.DepartmentId.ToString());
                }
                model.OrganizationId = org.Id;
                model.Document = Document;
                await _miscellaneousService.AddPolicy(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPost]
        [Route("createTerminationType")]
        public async Task<IActionResult> PostTerminationType([FromBody] TerminationTypeModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                model.OrganizationId = org.Id;
                await _miscellaneousService.AddTerminationType(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPost]
        [Route("createDesignation")]
        public async Task<IActionResult> PostDesignation([FromBody] DesignationModel model)
        {
            try
            {
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                model.OrganizationId = org.Id;
                await _miscellaneousService.AddDesignation(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateApplicant")]
        public async Task<IActionResult> UpdateApplicant([FromBody] ApplicantModel model)
        {
            try
            {
                await _miscellaneousService.UpdateApplicant(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPut]
        [Route("updateDepartment")]
        public async Task<IActionResult> UpdateDepartment([FromBody] DepartmentModel model)
        {
            try
            {
                await _miscellaneousService.UpdateDepartment(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPut]
        [Route("updatePolicy/{companyId}")]
        public async Task<IActionResult> UpdatePolicy([FromForm] PolicyModel model, int companyId)
        {
            try
            {
                var old = await _miscellaneousService.GetPolicy(model.Id);
                var org = await GetOrganizationByHeader();
                if (org == null)
                {
                    return BadRequest(new string[] { "You are not authorized with this hostname" });
                }
                string Document = null;
                var storeToBlob = bool.Parse(_config.GetSection("FileSystem")["StoreToBlob"]);
                if (storeToBlob && model.Uploadfile != null)
                {
                    // TODO Upload CV to documentManager
                    var blob = new BlobStore
                    {
                        FileName = model.Uploadfile.FileName,
                        ContentType = model.Uploadfile.ContentType,
                        FileLength = model.Uploadfile.Length,
                        FileStream = model.Uploadfile.OpenReadStream()
                    };

                    Document = await _fileManager.UploadFileToDepartmentFolder(blob, org.Name.Trim().ToLower().Replace(" ", ""), companyId.ToString(), model.DepartmentId.ToString());
                }
                model.Document = string.IsNullOrEmpty(Document) ? old.Document : Document;
                model.OrganizationId = org.Id;
                await _miscellaneousService.UpdatePolicy(model);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpPut]
        [Route("updateTerminationType")]
        public async Task<IActionResult> UpdateTerminationType([FromBody] TerminationTypeModel model)
        {
            try
            {
                await _miscellaneousService.UpdateTerminationType(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpPut]
        [Route("updateDesignation")]
        public async Task<IActionResult> UpdateDesignation([FromBody] DesignationModel model)
        {
            try
            {
                await _miscellaneousService.UpdateDesignation(model, model.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
        [Route("deleteApplicant")]
        public async Task<IActionResult> DeleteApplicant(int id)
        {
            try
            {
                await _miscellaneousService.RemoveApplicant(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpDelete]
        [Route("deleteDepartment")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            try
            {
                await _miscellaneousService.RemoveDepartment(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpDelete]
        [Route("deletePolicy")]
        public async Task<IActionResult> DeletePolicy(int id)
        {
            try
            {
                await _miscellaneousService.RemovePolicy(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize(Roles = "HRAdmin")]
        [HttpDelete]
        [Route("deleteTerminationType")]
        public async Task<IActionResult> DeleteTerminationType(int id)
        {
            try
            {
                await _miscellaneousService.RemoveTerminationType(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        [Authorize]
        [HttpDelete]
        [Route("deleteDesignation")]
        public async Task<IActionResult> DeleteDesignation(int id)
        {
            try
            {
                await _miscellaneousService.RemoveDesignation(id);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return CreateApiException(ex);
            }
        }

        
    }
}
