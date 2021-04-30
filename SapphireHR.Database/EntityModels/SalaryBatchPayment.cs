﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class SalaryBatchPayment : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public string BatchRef { get; set; }
        public string TotalAmount { get; set; }
        public string SourceAccount { get; set; }
        public string SourceBankCode { get; set; }
        public string Currency { get; set; }
        public string OriginalAccount { get; set; }
        public string OriginalBankCode { get; set; }
        public string CustomReference { get; set; }

        [ForeignKey("CompanyId")]
        public CompanyInfo Company { get; set; }
    }
}
