﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ExpenseTypeModel
    {
        public string Name { get; set; }
        public int ExpenseClaimId { get; set; }
        public ExpenseClaimModel ExpenseClaim { get; set; }
    }
}