using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ExpenseType : BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey("ExpenseClaimId")]
        public int ExpenseClaimId { get; set; }
        public ExpenseClaim ExpenseClaim { get; set; }
    }
}
