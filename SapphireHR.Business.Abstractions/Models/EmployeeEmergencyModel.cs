﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class EmployeeEmergencyModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
    }
}
