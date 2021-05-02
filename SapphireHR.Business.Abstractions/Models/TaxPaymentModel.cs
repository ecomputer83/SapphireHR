using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class TaxPaymentModel
    {
        public int TaxBatchPaymentId { get; set; }
        public int SalaryId { get; set; }
        public double TaxAmount { get; set; }
        public string TransactionRef { get; set; }
        public string StaffNumber { get; set; }
        public string StaffName { get; set; }
        public string BeneficiaryName { get; set; }
        public string Tin { get; set; }
        public string TaxState { get; set; }
        public string EmployeeCode { get; set; }
        public string Phone { get; set; }
        public string TransactionMonth { get; set; }
        public string Period { get; set; }
        public TaxBatchPaymentModel TaxBatchPayment { get; set; }
        public EmployeeSalaryModel Salary { get; set; }
    }
}
