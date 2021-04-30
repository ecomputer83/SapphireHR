using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class RemitaTaxRequest : BaseRequest
    {
        public string BatchRef { get; set; }
        public double TotalAmount { get; set; }
        public string SourceAccount { get; set; }
        public string SourceBankCode { get; set; }
        public List<TaxTransaction> Details { get; set; }
    }
    public class TaxTransaction
    {
        public double TaxAmount { get; set; }
        public string TransactionRef { get; set; }
        public string Company { get; set; }
        public string StaffNumber { get; set; }
        public string StaffName { get; set; }
        public string BeneficiaryName { get; set; }
        public string Tin { get; set; }
        public string TaxState { get; set; }
        public string EmployeeCode { get; set; }
        public string Phone { get; set; }
        public string TransactionMonth { get; set; }
        public string Period { get; set; }
    }
}
