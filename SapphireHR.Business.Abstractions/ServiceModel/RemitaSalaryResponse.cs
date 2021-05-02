using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions
{
    public class RemitaSalaryResponse : BaseResponse
    {
        public SalaryData data { get; set; }
    }

    public class SalaryData
    {
        public string batchRef { get; set; }
        public string authorizationId { get; set; }
        public double totalAmount { get; set; }
        public string transactionDate { get; set; }
    }
}
