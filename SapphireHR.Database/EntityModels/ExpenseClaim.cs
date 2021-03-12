using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ExpenseClaim : BaseEntity, IEntity
    {
        public DateTimeOffset? Date { get; set; }
        public string Remark { get; set; }
        public int Amount { get; set; }
        
        public int Assignee { get; set; }
        public int Approval { get; set; }
        public DateTimeOffset? ApprovalDate { get; set; }

        [ForeignKey("Assignee")]
        public Employee AssigneeEmployee { get; set; }
    }
}
