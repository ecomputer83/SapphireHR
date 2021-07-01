using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class DepartmentPolicyModel
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int PolicyId { get; set; }
    }
}
