using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class TaxBatchPaymentModel
    {
        public int CompanyId { get; set; }
        public string BatchRef { get; set; }
        public string TotalAmount { get; set; }
        public string SourceAccount { get; set; }
        public string SourceBankCode { get; set; }
        public CompanyModel Company { get; set; }
    }
}
