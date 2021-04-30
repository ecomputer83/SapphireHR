using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class SalaryPayment : BaseEntity, IEntity
    {
        public int SalaryBatchPaymentId { get; set; }
        public int SalaryId { get; set; }
        public string TransactionRef { get; set; }
        public string Amount { get; set; }
        public string DestinationAccount { get; set; }
        public string DestinationBankCode { get; set; }
        public string DestinationNarration { get; set; }

        [ForeignKey("SalaryBatchPaymentId")]
        public SalaryBatchPayment SalaryBatchPayment { get; set; }

        [ForeignKey("SalaryId")]
        public EmployeeSalary Salary { get; set; }
    }
}
