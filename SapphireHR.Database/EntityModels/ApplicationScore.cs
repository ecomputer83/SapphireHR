using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ApplicationScore : BaseEntity
    {
        [ForeignKey("ApplicationId")]
        public Application Application { get; set; }
        public string Score { get; set; }
    }
}
