using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class DisciplinaryMeasuresModel
    {
        public int Id { get; set; }
        public int QueryId { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Remark { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeModel Employee { get; set; }
        public QueryModel Query { get; set; }
    }

    public class QueryModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Form { get; set; }
        public string Accusation { get; set; }
        public DateTime Date { get; set; }
        public string Response { get; set; }
        public string ResponseBy { get; set; }
        public string QueryType { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
