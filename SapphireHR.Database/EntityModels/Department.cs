using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Department : BaseEntity, IEntity
    {
        public string Name { get; set; }
    }
}
