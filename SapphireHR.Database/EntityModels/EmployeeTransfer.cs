using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class EmployeeTransfer : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int FromCompany { get; set; }
        public int ToCompany { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
