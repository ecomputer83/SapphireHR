using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeTransferModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int FromCompany { get; set; }
        public int ToCompany { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
