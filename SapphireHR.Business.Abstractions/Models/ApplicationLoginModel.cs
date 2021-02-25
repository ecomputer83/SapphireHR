using System;
using System.Collections.Generic;
using System.Text;

namespace SapphireHR.Business.Abstractions.Models
{
    public class ApplicationLoginModel
    {
        public int ApplicationId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
