using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class CompanyAccount : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public string BankAccountForSalary { get; set; }
        public string BankCodeForSalary { get; set; }
        public string BankAccountForPension { get; set; }
        public string BankCodeForPension { get; set; }
        public string BankAccountForTax { get; set; }
        public string BankCodeForTax { get; set; }
        public string Currency { get; set; }
        public string EmployerCodeForPension { get; set; }
        public string RemitaUserAccount { get; set; }
        public string RemitaSecret { get; set; }
        public int SalaryPayDay { get; set; }

        [ForeignKey("CompanyId")]
        public CompanyInfo CompanyInfo { get; set; }
    }
}
