using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class OrganizationAccountModel
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string BankAccount { get; set; }
        public string BankCode { get; set; }
    }
}
