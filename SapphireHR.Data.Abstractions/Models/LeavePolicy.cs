﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class LeavePolicy : BaseEntity
    {
        public int LeaveTypeId { get; set; }
        public int TypeId { get; set; }
        public string PolicyName { get; set; }
        public int Days { get; set; }
        public LeaveType LeaveType { get; set; }
    }
}
