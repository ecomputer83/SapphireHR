using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ApplicationFaceToViewModel
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public string Rank { get; set; }
        public string Remark { get; set; }

        public int Status { get; set; }
    }
}
