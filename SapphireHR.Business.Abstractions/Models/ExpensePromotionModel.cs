using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ExpensePromotionModel
    {
        public int From { get; set; }
        public DesignationModel FromPromotion { get; set; }
        public int To { get; set; }
        public DesignationModel ToPromotion { get; set; }
        public DateTimeOffset Date { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
