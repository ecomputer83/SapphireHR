using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeResponsibilityCommentModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Strength { get; set; }
        public string AreaOfImprovement { get; set; }
    }
}
