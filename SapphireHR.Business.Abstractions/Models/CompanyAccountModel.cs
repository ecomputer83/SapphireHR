using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class CompanyAccountModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string BankAccount { get; set; }
        public string BankCode { get; set; }
    }
}
