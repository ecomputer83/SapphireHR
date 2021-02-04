﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class EmployeeEmergency : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public Employee Employee { get; set; }
    }
}
