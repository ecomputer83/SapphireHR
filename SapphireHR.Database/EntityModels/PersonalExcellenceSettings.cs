using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class PersonalExcellenceSettings : BaseEntity, IEntity
    {
        public int CompanyId { get; set; }
        public string KeyResult { get; set; }
        public string KeyPerformanceIndicator { get; set; }
        public int Weightage { get; set; }
        [ForeignKey("CompanyId")]
        public CompanyInfo CompanyInfo { get; set; }
    }
}
