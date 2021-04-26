using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class OrganizationSettingsModel
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public bool SalaryPaymentByOrg { get; set; }
        public DateTime SalaryStartDay { get; set; }
    }
}
