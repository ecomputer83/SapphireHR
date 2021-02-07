using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using SapphireHR.Business.DocumentManager.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Business.DocumentManager.Documents
{
    public class DocumentManager
    {
        IConfiguration _configuration;
        public DocumentManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> UploadFileToSharedFolder(BlobStore blob, string OrgFolder, string CompanyFolder)
        {
            string result = null;

            string storageConnection = _configuration.GetConnectionString("BlobStorageConnectionString");
            try
            {
                BlobContainerClient orgContainer = new BlobContainerClient(storageConnection, OrgFolder);

                if (!orgContainer.Exists())
                    orgContainer.Create();

                // Get a reference to a blob named "sample-file" in a container named "sample-container"
                BlobClient _blob = orgContainer.GetBlobClient(CompanyFolder + "/Shared/" + blob.FileName);
                await _blob.UploadAsync(blob.FileStream);
                result = _blob.Uri.AbsoluteUri;
            }
            catch (Exception ex)
            {
                //Log.Error(ex);
                throw new Exception(ex.Message, ex);
            }

            return result;
        }

        public async Task<string> UploadFileToEmployeeFolder(BlobStore blob, string OrgFolder, string CompanyFolder, string EmployeeId)
        {
            string result = null;

            string storageConnection = _configuration.GetConnectionString("BlobStorageConnectionString");
            try
            {
                BlobContainerClient orgContainer = new BlobContainerClient(storageConnection, OrgFolder);

                if (!orgContainer.Exists())
                    orgContainer.Create();

                // Get a reference to a blob named "sample-file" in a container named "sample-container"
                BlobClient _blob = orgContainer.GetBlobClient(CompanyFolder + "/"+EmployeeId+"/" + blob.FileName);
                await _blob.UploadAsync(blob.FileStream);
                result = _blob.Uri.AbsoluteUri;
            }
            catch (Exception ex)
            {
                //Log.Error(ex);
                throw new Exception(ex.Message, ex);
            }

            return result;
        }
        public Task<string> CreateOrgDirectory(string OrgFolder)
        {
            string result = null;

            string storageConnection = _configuration.GetConnectionString("BlobStorageConnectionString");
            try
            {
                BlobContainerClient orgContainer = new BlobContainerClient(storageConnection, OrgFolder);

                if (!orgContainer.Exists())
                    orgContainer.Create();

                result = orgContainer.Uri.AbsoluteUri;
            }
            catch (Exception ex)
            {
                //Log.Error(ex);
                throw new Exception(ex.Message, ex);
            }

            return Task.FromResult(result);
        }

        public Task<string> CreateCompanyDirectory(string OrgFolderUrl, string CompanyFolder)
        {
            string result = null;

            string storageConnection = _configuration.GetConnectionString("BlobStorageConnectionString");
            try
            {
                BlobContainerClient orgContainer = new BlobContainerClient(new Uri(OrgFolderUrl+"/"+CompanyFolder), null);

                if (!orgContainer.Exists())
                    orgContainer.Create();

                result = orgContainer.Uri.AbsoluteUri;
            }
            catch (Exception ex)
            {
                //Log.Error(ex);
                throw new Exception(ex.Message, ex);
            }

            return Task.FromResult(result);
        }
    }
}
