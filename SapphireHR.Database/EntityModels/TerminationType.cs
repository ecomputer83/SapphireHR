using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class TerminationType : BaseEntity, IEntity
    {
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        [ForeignKey("OrganizationId")]
        public OrganizationInfo Organization { get; set; }
    }
}
