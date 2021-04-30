using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class RemitaPensionRequest : BaseRequest
    {
        public string BatchRef { get; set; }
        public double TotalAmount { get; set; }
        public string SourceAccount { get; set; }
        public string SourceBankCode { get; set; }
        public List<PensionTransaction> Details { get; set; }
    }

    public class PensionTransaction
    {
        public double Amount { get; set; }
        public double EmployeeContribution { get; set; }
        public double EmployerContribution { get; set; }
        public double VoluntryContribution { get; set; }
        public string TransactionRef { get; set; }
        public string Company { get; set; }
        public string BeneficiarySurname { get; set; }
        public string BeneficiaryOtherName { get; set; }
        public string PfaCode { get; set; }
        public string PfaPin { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CustomerId { get; set; }
        public string EmployerCode { get; set; }
        public string TransactionMonth { get; set; }
        public string Period { get; set; }
    }
}
