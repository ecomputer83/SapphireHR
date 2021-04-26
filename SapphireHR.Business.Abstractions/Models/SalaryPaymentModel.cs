using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class SalaryPaymentModel
    {
        public int Id { get; set; }
        public int SalaryBatchPaymentId { get; set; }
        public string TransactionRef { get; set; }
        public string Amount { get; set; }
        public string DestinationAccount { get; set; }
        public string DestinationNarration { get; set; }
        public string Narration { get; set; }
    }
}
