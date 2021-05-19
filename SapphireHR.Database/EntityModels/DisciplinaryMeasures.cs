using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class DisciplinaryMeasures : BaseEntity, IEntity
    {
        public int QueryId { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Remark { get; set; }

        [ForeignKey("QueryId")]
        public Query Query { get; set; }
    }

    public class Query : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string Form { get; set; }
        public string Accusation { get; set; }
        public DateTime Date { get; set; }
        public string Response { get; set; }
        public string ResponseBy { get; set; }
        public string QueryType { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
