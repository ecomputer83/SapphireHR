using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class PolicyModel
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Document { get; set; }
        public DateTime CreatedAt { get; set; }
        public int DepartmentId { get; set; }
        public DepartmentModel Department { get; set; }
        public IFormFile Uploadfile { get; set; }
    }
}
