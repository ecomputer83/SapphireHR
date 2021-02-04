using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Skills : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
