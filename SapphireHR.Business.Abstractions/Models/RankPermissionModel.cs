﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class RankPermissionModel
    {
        public int Id { get; set; }
        public int RankId { get; set; }
        public bool ReadHoliday { get; set; }
        public bool ReadLeave { get; set; }
        public bool ReadAssets { get; set; }
        public bool ReadTimesheet { get; set; }
        public bool WriteHolidays { get; set; }
        public bool WriteLeave { get; set; }
        public bool WriteAssets { get; set; }
        public bool WriteTimesheet { get; set; }
        public bool DeleteHolidays { get; set; }
        public bool DeleteLeave { get; set; }
        public bool DeleteAssets { get; set; }
        public bool DeleteTimesheet { get; set; }
        public int Status { get; set; }
    }
}