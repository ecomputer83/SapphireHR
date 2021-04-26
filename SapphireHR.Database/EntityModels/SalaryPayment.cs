using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class SalaryPayment : BaseEntity, IEntity
    {
        public int SalaryBatchPaymentId { get; set; }
        public string TransactionRef { get; set; }
        public string Amount { get; set; }
        public string DestinationAccount { get; set; }
        public string DestinationNarration { get; set; }
        public string Narration { get; set; }

        [ForeignKey("SalaryBatchPaymentId")]
        public SalaryBatchPayment SalaryBatchPayment { get; set; }
    }
}
