using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class OrganizationHeader : BaseEntity
    {
        public int OrganizationId { get; set; }
        public string HostName { get; set; }
        public int Status { get; set; }

        [ForeignKey("OrganizationId")]
        public OrganizationInfo Organization { get; set; }
    }
}
