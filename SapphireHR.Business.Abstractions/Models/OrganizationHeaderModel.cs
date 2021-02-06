using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class OrganizationHeaderModel
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string HostName { get; set; }
        public int Status { get; set; }
    }
}
