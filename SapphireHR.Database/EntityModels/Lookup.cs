using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Lookup : BaseEntity, IEntity
    {
        public string LookupType { get; set; }
        public int LookupGroup { get; set; }
        public string LookupValue { get; set; }
        public string LookupDescription { get; set; }
        public int LookupSort { get; set; }
    }
}
