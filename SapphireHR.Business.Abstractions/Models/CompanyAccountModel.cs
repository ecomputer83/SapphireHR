using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class CompanyAccountModel
    {
        public int Id { get; set; }
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

        public CompanyModel CompanyInfo { get; set; }
    }
}
