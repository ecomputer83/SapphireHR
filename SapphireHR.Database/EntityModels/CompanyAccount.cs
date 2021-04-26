using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class CompanyAccount : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public string BankAccount { get; set; }
        public string BankCode { get; set; }

        [ForeignKey("CompanyId")]
        public CompanyInfo CompanyInfo { get; set; }
    }
}
