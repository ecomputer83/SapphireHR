using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class Holiday : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Day { get; set; }

    }
}
