using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class OrganizationAccount : BaseEntity, IEntity
    {
        public int OrganizationId { get; set; }
        public string BankAccount { get; set; }
        public string BankCode { get; set; }

        [ForeignKey("OrganizationId")]
        public OrganizationInfo OrganizationInfo { get; set; }
    }
}
