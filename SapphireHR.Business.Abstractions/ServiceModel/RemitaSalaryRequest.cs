using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class RemitaSalaryRequest : BaseRequest
    {
        public string BatchRef { get; set; }
        public double TotalAmount { get; set; }
        public string SourceAccount { get; set; }
        public string SourceAccountName { get; set; }
        public string SourceBankCode { get; set; }
        public string Currency { get; set; }
        public string SourceNarration { get; set; }
        public string OriginalAccountNumber { get; set; }
        public string OriginalBankCode { get; set; }
        public string CustomReference { get; set; }
        public List<SalaryTransaction> Transactions { get; set; }
    }

    public class SalaryTransaction
    {
        public double Amount { get; set; }
        public string TransactionRef { get; set; }
        public string DestinationAccount { get; set; }
        public string DestinationAccountName { get; set; }
        public string DestinationBankCode { get; set; }
        public string DestinationNarration { get; set; }
    }
}
