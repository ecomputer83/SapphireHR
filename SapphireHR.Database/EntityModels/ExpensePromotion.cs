using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ExpensePromotion : BaseEntity
    {

        [ForeignKey("DesignationId")]
        public int From { get; set; }
        public Designation FromPromotion { get; set; }
        [ForeignKey("DesignationId")]
        public int To { get; set; }
        public Designation ToPromotion { get; set; }
        public DateTimeOffset Date { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
