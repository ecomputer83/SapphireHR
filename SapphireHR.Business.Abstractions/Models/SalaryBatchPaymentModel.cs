using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class SalaryBatchPaymentModel
    {
        public int PrincipalId { get; set; }
        public int PrincipaTypelId { get; set; }
        public string BatchRef { get; set; }
        public string TotalAmount { get; set; }
        public string SourceAccount { get; set; }
        public string SourceBankCode { get; set; }
        public string Currency { get; set; }
        public string OriginalAccount { get; set; }
        public string OriginalBankCode { get; set; }
        public string CustomReference { get; set; }
    }
}
