using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class OrganizationSettings : BaseEntity, IEntity
    {
        public int OrganizationId { get; set; }
        public bool SalaryPaymentByOrg { get; set; }
        public DateTime SalaryStartDay { get; set; }

        [ForeignKey("OrganizationId")]
        public OrganizationInfo OrganizationInfo { get; set; }
    }
}
