using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ProffesionalExcellenceSettings : BaseEntity, IEntity
    {
        public string KeyResult { get; set; }
        public string KeyPerfomanceIndicator { get; set; }
        public int Weightage { get; set; }
    }
}
