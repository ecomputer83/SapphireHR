﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class SkillTypeModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
    }
}
