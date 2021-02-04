using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SapphireHR.Database.EntityModels
{
    public class ApplicationFaceToView : BaseEntity
    {
        public string Rank { get; set; }
        public string Remark { get; set; }
        [ForeignKey("ApplicationId")]
        public Application Application { get; set; }
    }
}
