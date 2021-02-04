using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Data.Abstractions.Models
{
    public class ApplicationFaceToView : BaseEntity
    {
        public int ApplicationId { get; set; }
        public string Rank { get; set; }
        public string Remark { get; set; }
        public Application Application { get; set; }
    }
}
