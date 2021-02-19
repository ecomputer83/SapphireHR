using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeBankModel
    {
        public int Id { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public int EmployeeId { get; set; }
    }
}
