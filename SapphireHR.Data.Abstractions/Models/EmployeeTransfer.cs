using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class EmployeeTransfer : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int FromCompany { get; set; }
        public int ToCompany { get; set; }
        public DateTime DateJoined { get; set; }
        public Employee Employee { get; set; }
    }
}
